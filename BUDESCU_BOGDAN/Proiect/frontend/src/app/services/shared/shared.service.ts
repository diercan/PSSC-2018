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
  public selectedProducts: any[]=[];
  public products: any[];
  constructor() {
    this.getUserName();
  }

  public getUserName() {
    if (localStorage.getItem('token') != null) {
      console.log(jwt_decode(localStorage.getItem('token')));
      this.userData = jwt_decode(localStorage.getItem('token'))["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"];
      this.role = jwt_decode(localStorage.getItem('token'))["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
      this.id = jwt_decode(localStorage.getItem('token'))["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"];
      console.log(this.userData, this.role, this.id);
    }
    else {
      this.userData = "";
    }
  }
}
