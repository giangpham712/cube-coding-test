import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { ApiInterceptor } from './interceptors/api.interceptor';
import { TemperatureConversionService } from './services/temperature-conversion.service';

@NgModule({
  imports: [],
  exports: [],
  declarations: [],
  providers: [
    TemperatureConversionService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: ApiInterceptor,
      multi: true
    }
  ],
})
export class CoreModule { }
