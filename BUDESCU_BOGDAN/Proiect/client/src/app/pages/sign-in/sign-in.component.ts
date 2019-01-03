import { Component, OnInit, SimpleChanges, OnChanges, AfterViewInit, OnDestroy } from '@angular/core';
import { SignIn } from 'src/app/models/SignIn';
import { CryptoService } from 'src/app/services/crypto/crypto.service';
import { HttpService } from 'src/app/services/http/http.service';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit, OnChanges, AfterViewInit, OnDestroy {
  public signInUserModel: SignIn = new SignIn("", "");
  public messageSuccess: string = ""
  public messageError: string = ""
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

  public onSubmitSignInForm(): void {
    console.log(this.signInUserModel)

    let signInData = new SignIn(
      this.signInUserModel.Email,
      this.signInUserModel.Password
    );

    //cripteaza parola pentru a transmite a nu se transmite parola direct pe request...
    let encryptedPassword = this.cryptoService.encrypt(signInData.Password);
    signInData.Password = encryptedPassword;
    console.log(signInData)
    this.httpService.login(signInData).subscribe(
      (data: any) => {
        this.messageSuccess = data.message;
        localStorage.setItem("token", data.token);
        setTimeout(() => { this.messageSuccess = "" }, 3000);
      },
      (err: HttpErrorResponse) => {
        this.messageError = err.error.message
        setTimeout(() => { this.messageError = "" }, 3000);
      })
  }

  public signInWithFacebook(): void {
    console.log("signInWithFacebook - work in progress")
  }

  public signInWithGoogle(): void {
    console.log("signInWithGoogle - work in progress")
  }
}
