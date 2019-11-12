import {Injectable} from '@angular/core';
import {Router} from "@angular/router";
import {HttpClient} from "@angular/common/http";
import conf from "../configs/conf";
import {User} from "../models/user";
import {Observable} from "rxjs/internal/Observable";
import {Subject} from "rxjs/internal/Subject";

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  readonly authChangeEvent = new Subject();

  constructor(private http: HttpClient,
              private router: Router
  ) {
  }

  login(credentials: any) {
    const options = {
      headers: {
        'Authorization': 'Basic ' + btoa(`${credentials.username}:${credentials.password}`)
      }
    };

    this.http.get(conf.basePath + '/users/profile', options).subscribe((data: any) => {
        localStorage.setItem('user', JSON.stringify(data));
        this.authChangeEvent.next();
        this.router.navigate(['home']);
      },
      (error) => {
        this.authChangeEvent.next();
        alert('Could not login!');
      });
  }

  getAuthenticatedUser(): User | null {
    const user = localStorage.getItem('user');
    return !!user ? <User> JSON.parse(localStorage.getItem('user')) : null ;
  }

  isAuthenticated(): boolean {
    return !!localStorage.getItem('user');
  }

  logout() {
    localStorage.removeItem('user');
    this.authChangeEvent.next();
    this.router.navigate(['login']);
  }
}
