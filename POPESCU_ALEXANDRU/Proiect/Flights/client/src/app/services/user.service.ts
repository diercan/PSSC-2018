import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import conf from "../configs/conf";
import {User} from "../models/user";
import {AuthService} from "./auth.service";

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient,
              private auth: AuthService
  ) { }

  create(credentials) {
    this.http.post(conf.basePath + '/users', credentials).subscribe((user: User) => {
      this.auth.login(user);
    })
  }
}
