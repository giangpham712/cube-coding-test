import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { tap } from 'rxjs/operators';
import { TemperatureConversionService } from 'src/app/core/services/temperature-conversion.service';
import { notEqualValidator } from '../../shared/helpers/form-validators';
import { TemperatureScaleModel } from '../../shared/models/temperature-scale.model';

@Component({
  selector: 'app-converter',
  templateUrl: 'converter.component.html',
  styleUrls: ['converter.component.scss']
})

export class ConverterComponent implements OnInit {

  temperatureScales: TemperatureScaleModel[] = [];

  convertedValue: number = null;

  form: FormGroup;

  constructor(
    private fb: FormBuilder,
    private temperatureConversionService: TemperatureConversionService
  ) { }

  ngOnInit() { 
    this.form = this.fb.group({
      fromScale: [null, Validators.required],
      toScale: [null, Validators.required],
      value: [null, Validators.required]
    }, {
      validators: [
        notEqualValidator('toScale', 'fromScale')
      ]
    });
    this.temperatureConversionService.listTemperatureScales()
      .pipe(tap(scales => {
        this.temperatureScales = scales;
      }))
      .subscribe();
  }

  get fromScale() {
    const fromScaleName = this.form.controls['fromScale'].value;
    return this.temperatureScales.find(x => x.name === fromScaleName);
  }

  get toScale() {
    const toScaleName = this.form.controls['toScale'].value;
    return this.temperatureScales.find(x => x.name === toScaleName);
  }

  submit() {
    if (!this.form.valid) {
      return;
    }

    this.temperatureConversionService.convert(this.form.value)
      .pipe(tap(result => {
        this.convertedValue = result.convertedValue;
      }))
      .subscribe();
  }
}