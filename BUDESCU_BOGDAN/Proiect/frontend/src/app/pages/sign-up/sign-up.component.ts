import { Component, OnInit, SimpleChanges, OnChanges, AfterViewInit, OnDestroy, ViewChild } from '@angular/core';
import { SignUp } from 'src/app/models/SignUp';
import { NgForm } from '@angular/forms';
import { HttpService } from 'src/app/services/http/http.service';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent  {
  public signUpUserModel: SignUp = new SignUp("", "", "");
  public messageSuccess: string = ""
  public messageError: string = ""
  @ViewChild("signUpForm") signUpForm: NgForm;
  constructor(
    public httpService: HttpService
  ) { }

  
  public onSubmitSignUpForm(): void {

    //verifica daca form pt register este valid
    if (!this.signUpForm.form.valid) {
      console.log("form is not valid");
      //intrerupe executia metodei
      return;
    }

    //creeaza un nou obiect de tip SignUp (/models/SignUp)
    let signUpData = new SignUp(
      this.signUpUserModel.UserName,
      this.signUpUserModel.Password,
      this.signUpUserModel.ConfirmPassword
    );

    this.httpService.register(signUpData).subscribe(
      (data: any) => {
        this.messageSuccess = data.message;
        setTimeout(() => { this.messageSuccess = "" }, 3000);
      },
      (err: HttpErrorResponse) => {
        this.messageError = err.error.message
        setTimeout(() => { this.messageError = "" }, 3000);
      });
  }

}
