import { Component, OnInit, OnChanges, AfterViewInit, OnDestroy, SimpleChanges } from '@angular/core';
import { HttpService } from 'src/app/services/http/http.service';
import { Customer } from 'src/app/models/Customer';
import { SharedService } from 'src/app/services/shared/shared.service';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent {

  public tableHead = [
    { name: "firstName", colspan: 1 },
    { name: "lastName", colspan: 1 },
    { name: "email", colspan: 1 },
    { name: "userName", colspan: 2 },
    { name: "password", colspan: 2 },
    { name: "adress", colspan: 2 },
    { name: "image", colspan: 2 }
  ];
  public customers: Customer[] = [];
  public showCreateCustomerForm: boolean = false;
  public createUserModel: Customer = new Customer("","","","","","","","","","","");
  public updateUserModel: Customer = new Customer("","Budescu","Bogdan","bude@gmail.com","","","","","","","");

  public buttonMessage_1: string = "Show Create Customer Form";
  constructor(
    private httpService : HttpService,
    private sharedService : SharedService,
    private router : Router,
    ) 
    {
    this.getCustomers();
    if(this.sharedService.role != 'Manager')
    {
      this.router.navigateByUrl('/products')
    }
   }
 
  public getCustomers() {
    this.httpService.getCustomers().subscribe((result: Customer[]) => {
      this.customers = result;
    });
  }

  public deleteCustomer(id: string) {

    this.httpService.deleteCustomer(id).subscribe((result) => {
      this.getCustomers();
    }, (err) => {
      console.log(err)
    })
  }

  public showCreateCustomer() {

    if (this.showCreateCustomerForm) {
      this.buttonMessage_1 = "Show Create Customer Form";
      this.showCreateCustomerForm = false;
    } else {
      this.buttonMessage_1 = "Hide Create Customer Form";
      this.showCreateCustomerForm = true;
    }
  }

  public showUpdateCustomer(customer: Customer) {

    if (this.updateUserModel.id == customer.id) {
      this.updateUserModel = new Customer("99","Budescu","Bogdan","bude@gmail.com","","","","","","","");
    } else if (this.updateUserModel.id !=  customer.id) {
      this.updateUserModel = new Customer(customer.id,customer.firstName,customer.lastName,customer.email,
                             customer.countryId,customer.userName,customer.password,customer.street,
                             customer.zipCode,customer.city,customer.image);
    }
  
  }

  public onSubmitCreateCustomerForm() {

    this.httpService.createCustomer(this.createUserModel).subscribe((result) => {
      this.getCustomers();
    })
  }

  public onSubmitUpdateCustomerForm() {

    this.httpService.updateCustomer(this.updateUserModel).subscribe((result) => {
      this.getCustomers();
    })
  }

}
