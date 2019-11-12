import {Component, OnInit, ViewChild} from '@angular/core';
import {UserService} from "../../services/user.service";
import {NgForm} from "@angular/forms";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @ViewChild('registerForm') registerForm: NgForm;
  constructor(private userService: UserService) { }

  ngOnInit() {
  }

  registerAccount() {
    if(this.registerForm.errors) {
      alert('err');
      return;
    }
    this.userService.create(this.registerForm.value);
  }
}
