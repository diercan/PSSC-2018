import { TestBed, async } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { MenuComponent } from './pages/menu/menu.component';
import { EmployeeComponent } from './pages/employee/employee.component';
import { SignInComponent } from './pages/sign-in/sign-in.component';

import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from 'src/app/router/app.routing.module';
import { MaterialModule } from 'src/app/material/material.module';
import { APP_BASE_HREF } from '@angular/common';

describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        AppComponent,
        MenuComponent,
        EmployeeComponent,
        SignInComponent
      ],
      imports: [
        FormsModule,
        HttpClientModule,
        BrowserAnimationsModule,
        AppRoutingModule,
        MaterialModule
      ],
      providers: [{ provide: APP_BASE_HREF, useValue: '/' }]
    }).compileComponents();
  }));

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  });

});
