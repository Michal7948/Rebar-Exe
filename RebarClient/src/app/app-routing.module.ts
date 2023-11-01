import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MenuComponent } from './menu/menu.component';
import { AddShakeComponent } from './add-shake/add-shake.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { OrdersComponent } from './orders/orders.component';
import { CreateOrderComponent } from './create-order/create-order.component';
import { AllPageFormComponent } from './all-page-form/all-page-form.component';
import { AddShakeOrderComponent } from './add-shake-order/add-shake-order.component';
import { MessageCreateOrderComponent } from './message-create-order/message-create-order.component';

const routes: Routes = [
  {path: '',component:HomeComponent},
  {path:'Home',component:HomeComponent},
  {path:'Menu',component:MenuComponent},
  {path:'orders',component:OrdersComponent},
  {path:'inputs',component:AllPageFormComponent,children: [
    {path:'addShake',component:AddShakeComponent},
    { path: 'createOrder', component: CreateOrderComponent },
    {path:'addShakeOrder',component:AddShakeOrderComponent},
    {path:'message',component:MessageCreateOrderComponent}
  ]},
  {path:'**',component:NotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
