import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { ConvertTemperatureResultModel } from 'src/app/shared/models/convert-temperature-result.model';
import { ConvertTemperatureModel } from 'src/app/shared/models/convert-temperature.model';
import { TemperatureScaleModel } from 'src/app/shared/models/temperature-scale.model';

@Injectable()
export class TemperatureConversionService {
  constructor(private httpClient: HttpClient) { }
  
  listTemperatureScales(): Observable<TemperatureScaleModel[]> {
    return this.httpClient.get<TemperatureScaleModel[]>('TemperatureConversion/ListTemperatureScales');
  }

  convert(conversionModel: ConvertTemperatureModel): Observable<ConvertTemperatureResultModel> {
    return this.httpClient.post<ConvertTemperatureResultModel>('TemperatureConversion/Convert', conversionModel);
  }
}