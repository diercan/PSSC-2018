import { Component, OnInit } from '@angular/core';
import { HttpService } from 'src/app/services/http/http.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { Route, Router } from '@angular/router';
import { Customer } from 'src/app/models/Customer';


@Component({
  selector: 'app-my-account',
  templateUrl: './my-account.component.html',
  styleUrls: ['./my-account.component.css']
})
export class MyAccountComponent {

  public customers: Customer[] = [];
  public updateUserModel: Customer = new Customer("","Budescu","Bogdan","bude@gmail.com","","","","","","","");
  constructor(
    private httpService: HttpService,
    private sharedService: SharedService,
    private router: Router,
  ) { }

  public getDataCustomer()
   {
    this.httpService. getCustomerById(this.sharedService.id).subscribe((result: Customer[]) => {
      this.customers = result;
    });
   }

   public updateDataCustomer()
   {
    this.httpService.updateCustomer(this.updateUserModel).subscribe((result) => {
      this.httpService. getCustomerById(this.sharedService.id);
      this.getDataCustomer();
    });
   }
}
