import { Component, OnInit, OnChanges, AfterViewInit, OnDestroy, SimpleChanges } from '@angular/core';
import { HttpService } from 'src/app/services/http/http.service';
import { Customer } from 'src/app/models/Customer';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit , OnChanges, AfterViewInit, OnDestroy{

  public tableHead = [
    { name: "Id", colspan: 1 },
    { name: "firstName", colspan: 1 },
    { name: "lastName", colspan: 1 },
    { name: "email", colspan: 1 },
    { name: "countryId", colspan: 2 }
  ];
  public customers: Customer[] = [];
  public showCreateCustomerForm: boolean = false;
  public createUserModel: Customer = new Customer("","","","","");
  public updateUserModel: Customer = new Customer("","Budescu","Bogdan","bude@gmail.com","");

  public buttonMessage_1: string = "Show Create Customer Form";
  constructor(private httpService : HttpService) {
    this.getCustomers();
   }

   ngOnChanges(changes: SimpleChanges): void {
    //Called before any other lifecycle hook. Use it to inject dependencies, but avoid any serious work here.
    //Add '${implements OnChanges}' to the class.

  }

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.

  }

  ngAfterViewInit(): void {
    //Called after ngAfterContentInit when the component's view has been initialized. Applies to components only.
    //Add 'implements AfterViewInit' to the class.

  }

  ngOnDestroy(): void {
    //Called once, before the instance is destroyed.
    //Add 'implements OnDestroy' to the class.

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
      this.updateUserModel = new Customer("99","Budescu","Bogdan","bude@gmail.com","");
    } else if (this.updateUserModel.id !=  customer.id) {
      this.updateUserModel = new Customer(customer.id,customer.firstName,customer.lastName,customer.email,customer.countryId)
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
