import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from 'src/app/router/app.routing.module';
import { MaterialModule } from 'src/app/material/material.module';
import { SignInComponent } from '../sign-in/sign-in.component';
import { APP_BASE_HREF } from '@angular/common';
import { EmployeeComponent } from '../employee/employee.component';

describe('SignInComponent', () => {
  let component: SignInComponent;
  let fixture: ComponentFixture<SignInComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [SignInComponent, EmployeeComponent, SignInComponent],
      imports: [
        FormsModule,
        HttpClientModule,
        BrowserAnimationsModule,
        AppRoutingModule,
        MaterialModule
      ],
      providers: [{ provide: APP_BASE_HREF, useValue: '/' }]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SignInComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
