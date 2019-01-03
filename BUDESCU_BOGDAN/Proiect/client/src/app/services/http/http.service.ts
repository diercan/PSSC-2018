import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpEvent } from '@angular/common/http';
import { Observable, Subject } from 'rxjs';
import { HttpParamsOptions, HttpParams } from '@angular/common/http/src/params';
import { SignUp } from 'src/app/models/SignUp';
import { SignIn } from 'src/app/models/SignIn';
import { Customer } from 'src/app/models/Customer';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  public server: any = "http://192.168.1.7:5000";
  constructor(private http: HttpClient) { }

  public getCustomerById(id: number): Observable<any> {

    let options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': localStorage.getItem('token') || ''
      })
    };
    return this.http.get<Customer>(`${this.server}/api/customer/${id}`, options);
  }

  public getCustomers(): Observable<Customer[]> {
    
    let options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': localStorage.getItem('token') || ''
      })
    };
    return this.http.get<Customer[]>(`${this.server}/api/customer`, options);
  }

  public deleteCustomer(id: string): Observable<any> {

    let options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': localStorage.getItem('token') || ''
      }),
    };
    return this.http.delete(`${this.server}/api/customer/${id}`, options);
  }

  public updateCustomer(customer: Customer) {

    let body = JSON.stringify(customer);
    let options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': localStorage.getItem('token') || ''
      })
    };
    return this.http.put(`${this.server}/api/customer/${customer.id}`, body, options);
  }

  public createCustomer(customer: Customer) {

    let body = JSON.stringify(customer);
    let options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': localStorage.getItem('token') || ''
      })
    };
    return this.http.post(`${this.server}/api/customer`, body, options);
  }

  public regiser(signUpData: SignUp) {

    let body = JSON.stringify(signUpData);
    let options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };
    return this.http.post(`${this.server}/api/users/register`, body, options);
  }

  public login(signInData: SignIn) {

    let body = JSON.stringify(signInData);
    let options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };
    return this.http.post(`${this.server}/api/users/login`, body, options);
 
  }


}
