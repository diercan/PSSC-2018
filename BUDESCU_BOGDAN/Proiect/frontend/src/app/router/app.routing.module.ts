import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { SignInComponent } from '../pages/sign-in/sign-in.component';
import { SignUpComponent } from '../pages/sign-up/sign-up.component';
import { CustomerComponent } from '../pages/customer/customer.component';
import { ProductComponent } from '../pages/product/product.component';
import { BagComponent } from '../pages/bag/bag.component';


const routes: Routes = [
    { path: '', component: CustomerComponent },
    { path: 'sign-in', component: SignInComponent },
    { path: 'sign-up', component: SignUpComponent },
    { path: 'customer', component: CustomerComponent },
    { path: 'products', component: ProductComponent },
    { path: 'bag', component: BagComponent },
    
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
