import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

export class ApiInterceptor implements HttpInterceptor {
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const baseApiUrl = environment.baseApiUrl;
    const request = req.clone({
      url: `${baseApiUrl}${req.url}`
    });
    return next.handle(request);
  }

}