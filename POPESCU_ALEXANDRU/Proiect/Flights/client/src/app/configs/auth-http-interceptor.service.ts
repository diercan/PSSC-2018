import { Injectable } from '@angular/core';
import {HttpEvent, HttpHandler, HttpInterceptor, HttpRequest} from "@angular/common/http";
import {Observable} from "rxjs/internal/Observable";
import {AuthService} from "../services/auth.service";

@Injectable({
  providedIn: 'root'
})
export class AuthHttpInterceptor implements HttpInterceptor {

  constructor(private auth: AuthService) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    if (!this.auth.isAuthenticated()) {
      return next.handle(req);
    }

    const user = this.auth.getAuthenticatedUser();

    const requestClone = req.clone({
      setHeaders: {
        'Authorization': 'Basic ' + btoa(`${user.username}:${user.password}`)
      }
    });

    return next.handle(requestClone);
  }
}
