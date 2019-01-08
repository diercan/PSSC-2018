import { Injectable } from '@angular/core';
import * as jwt_decode from "jwt-decode";

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  public isLoggedIn: boolean = localStorage.getItem('token') != null;
  public userData: any;
  public id: any;
  public role: any;
  constructor() {
    this.getUserName();
  }

  public getUserName() {
    if (localStorage.getItem('token') != null) {
      console.log(jwt_decode(localStorage.getItem('token')));
      this.userData = jwt_decode(localStorage.getItem('token'))["UserName"];
      this.role = jwt_decode(localStorage.getItem('token'))["Role"];
      this.id = jwt_decode(localStorage.getItem('token'))["Id"];
      console.log(this.userData, this.role, this.id);
    }
    else {
      this.userData = "";
    }
  }
}
