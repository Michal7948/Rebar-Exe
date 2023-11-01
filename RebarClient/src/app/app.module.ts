import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MenuComponent } from './menu/menu.component';
import { ShakeService } from './services/shake.service';
import { AddShakeComponent } from './add-shake/add-shake.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { OrdersComponent } from './orders/orders.component';
import { OrderService } from './services/order.service';
import { CreateOrderComponent } from './create-order/create-order.component';
import { AllPageFormComponent } from './all-page-form/all-page-form.component';
import { AddShakeOrderComponent } from './add-shake-order/add-shake-order.component';
import { MessageCreateOrderComponent } from './message-create-order/message-create-order.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MenuComponent,
    AddShakeComponent,
    NotFoundComponent,
    OrdersComponent,
    CreateOrderComponent,
    AllPageFormComponent,
    AddShakeOrderComponent,
    MessageCreateOrderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    
  ],
  providers: [
    ShakeService,
    OrderService,
    NgModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
