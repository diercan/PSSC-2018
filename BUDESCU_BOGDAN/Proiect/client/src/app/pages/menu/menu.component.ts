import { Component, OnInit, SimpleChanges, OnChanges, AfterViewInit, OnDestroy } from '@angular/core';
import { SharedService } from 'src/app/services/shared/shared.service';
import * as jwt_decode from "jwt-decode";

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent {

  constructor(
    public sharedService : SharedService
    
  ) { }


  public expandMenu(): void {

    let navbar: HTMLElement = document.getElementById("navbarResponsive");
    let isExpanded: boolean = navbar.style.display != "none" ;
    if (isExpanded) {
      navbar.style.display = "none";
    } else {
      navbar.style.display = "block";
    }
  }

  public closeExpandedMenu() {
    
    let navbar: HTMLElement = document.getElementById("navbarResponsive");
    navbar.style.display = "none" 
  }

  public logOut()
  {
    this.sharedService.isLoggedIn = false;
    localStorage.removeItem('token');
    this.sharedService.getUserName();
  }
}
