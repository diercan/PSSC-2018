import { Component, OnInit, SimpleChanges, OnChanges, AfterViewInit, OnDestroy, ViewChild } from '@angular/core';
import { SignUp } from 'src/app/models/SignUp';
import { CryptoService } from 'src/app/services/crypto/crypto.service';
import { NgForm } from '@angular/forms';
import { HttpService } from 'src/app/services/http/http.service';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit, OnChanges, AfterViewInit, OnDestroy {
  public signUpUserModel: SignUp = new SignUp("", "", "", "", "");
  public messageSuccess: string = ""
  public messageError: string = ""
  @ViewChild("signUpForm") signUpForm: NgForm;
  constructor(
    public cryptoService: CryptoService,
    public httpService: HttpService
  ) { }

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

  public onSubmitSignUpForm(): void {

    //verifica daca form pt register este valid
    if (!this.signUpForm.form.valid) {
      console.log("form is not valid");
      //intrerupe executia metodei
      return;
    }

    //creeaza un nou obiect de tip SignUp (/models/SignUp)
    let signUpData = new SignUp(
      this.signUpUserModel.FirstName,
      this.signUpUserModel.LastName,
      this.signUpUserModel.Email,
      this.signUpUserModel.Password,
      this.signUpUserModel.ConfirmPassword
    );

    //cripteaza parola pentru a transmite a nu se transmite parola direct pe request...
    let encryptedPassword = this.cryptoService.encrypt(signUpData.Password);
    signUpData.Password = encryptedPassword;
    signUpData.ConfirmPassword = encryptedPassword;

    this.httpService.regiser(signUpData).subscribe(
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
