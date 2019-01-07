import { Component, OnInit } from '@angular/core';
import {AuthService} from "../../services/auth.service";
import {User} from "../../models/user";

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  user?: User;

  constructor(private authService: AuthService) { }

  ngOnInit() {
    this.user = this.authService.getAuthenticatedUser();
    this.authService.authChangeEvent.subscribe(() => this.user = this.authService.getAuthenticatedUser());
  }

  logout() {
    this.authService.logout();
  }
}
