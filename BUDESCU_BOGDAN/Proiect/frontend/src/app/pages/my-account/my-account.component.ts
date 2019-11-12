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

  public customer: Customer;
  public updateUserModel: Customer = new Customer("","","","","","","","","","","");
  public buttonMessage_1: string = "Edit Data";
  public showCreateDataCustomerForm: boolean = false;
  constructor(
    private httpService: HttpService,
    private sharedService: SharedService,
    private router: Router,
  ) { 
    this.getDataCustomer();
  }

  public showCreateDataCustomer() {

    if (this.showCreateDataCustomerForm) {
      this.buttonMessage_1 = "Edit Data";
      this.showCreateDataCustomerForm = false;
    } else {
     // this.buttonMessage_1 = "Hide Create Customer Form";
      this.showCreateDataCustomerForm = true;
    }
  }

  public getDataCustomer()
   {
    this.httpService. getCustomerById(this.sharedService.id).subscribe((result: Customer) => {
      this.customer = result;
      this.updateUserModel = result;
      console.log(this.customer);
      this.customer.userName = result.user.username;
    });
   }

   public updateDataCustomer()
   {
    this.httpService.updateCustomer(this.updateUserModel).subscribe((result) => {
      this.getDataCustomer();
    });
   }

   public onSubmitUpdateDataCustomerForm() {

    this.httpService.updateCustomer(this.updateUserModel).subscribe((result) => {
      this.getDataCustomer();
    })
  }

  public showUpdateDataCustomer(customer: Customer) {

    if (this.updateUserModel.id == customer.id) {
      this.updateUserModel = new Customer("","","","","","","","","","","");
    } else if (this.updateUserModel.id !=  customer.id) {
      this.updateUserModel = new Customer(customer.id,customer.firstName,customer.lastName,customer.email,
                             customer.countryId,customer.userName,customer.password,customer.street,
                             customer.zipCode,customer.city,customer.image);
    }
  }
}
