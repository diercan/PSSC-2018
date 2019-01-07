import { Component, OnInit, SimpleChanges, OnChanges, AfterViewInit, OnDestroy } from '@angular/core';
import { SignIn } from 'src/app/models/SignIn';
import { CryptoService } from 'src/app/services/crypto/crypto.service';
import { HttpService } from 'src/app/services/http/http.service';
import { HttpErrorResponse } from '@angular/common/http';
import { SharedService } from 'src/app/services/shared/shared.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent  {
  public signInUserModel: SignIn = new SignIn("", "");
  public messageSuccess: string = ""
  public messageError: string = ""
  constructor(
    public httpService: HttpService,
    public sharedService: SharedService,
    public router : Router,
  ) { 
    if(this.sharedService.isLoggedIn == true)
    {
      this.router.navigateByUrl('/products')
    }
  }


  public onSubmitSignInForm(): void {
    console.log(this.signInUserModel)

    let signInData = new SignIn(
      this.signInUserModel.UserName,
      this.signInUserModel.Password
    );

    
    console.log(signInData)
    this.httpService.login(signInData).subscribe(
      (data: any) => {
        this.messageSuccess = data.message;
        localStorage.setItem("token", data.token);
        setTimeout(() => { this.messageSuccess = "" }, 3000);
        this.sharedService.isLoggedIn = true;
        this.sharedService.getUserName();
        this.router.navigateByUrl('/products')
      },
      (err: HttpErrorResponse) => {
        this.messageError = err.error.message
        setTimeout(() => { this.messageError = "" }, 3000);
        this.sharedService.isLoggedIn = false;
      })
  }
}
