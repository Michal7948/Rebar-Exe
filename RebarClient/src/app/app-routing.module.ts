import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MenuComponent } from './menu/menu.component';
import { AddShakeComponent } from './add-shake/add-shake.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { OrdersComponent } from './orders/orders.component';

const routes: Routes = [
  {path: '',component:HomeComponent},
  {path:'Home',component:HomeComponent},
  {path:'Menu',component:MenuComponent},
  {path:'addShake',component:AddShakeComponent},
  {path:'orders',component:OrdersComponent},
  {path:'**',component:NotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
