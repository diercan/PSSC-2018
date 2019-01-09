import {Route} from '@angular/router';
import {HomeComponent} from "../components/home/home.component";
import {LoginComponent} from "../components/login/login.component";
import {RegisterComponent} from "../components/register/register.component";
import {AnonymousGuard} from "../guards/anonymous.guard";
import {CustomerGuard} from "../guards/customer.guard";
import {BookingsComponent} from "../components/bookings/bookings.component";
import {AdminGuard} from "../guards/admin.guard";
import {ManageFlightsComponent} from "../components/manage-flights/manage-flights.component";
import {EventComponent} from "../components/event/event.component";

const routes: Route[] = [
  {path: '', redirectTo: 'home', pathMatch: 'full'},
  {path: 'home', component: HomeComponent},
  {path: 'bookings', component: BookingsComponent, canActivate: [CustomerGuard]},
  {path: 'login', component: LoginComponent, canActivate: [AnonymousGuard]},
  {path: 'register', component: RegisterComponent, canActivate: [AnonymousGuard]},
  {path: 'flights/manage', component: ManageFlightsComponent, canActivate: [AdminGuard]},
  {path: 'events', component: EventComponent, canActivate : [AdminGuard]},
];

export default routes;
