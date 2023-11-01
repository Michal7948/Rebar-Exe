import { Component } from '@angular/core';
import { Shakes } from '../model/shake';
import { ShakeService } from '../services/shake.service';
import { ShakeForOrder } from '../model/shakeForOrder';
import { FormControl, FormGroup } from '@angular/forms';
import { Orders } from '../model/orders';
import { OrderService } from '../services/order.service';

@Component({
  selector: 'app-create-order',
  templateUrl: './create-order.component.html',
  styleUrls: ['./create-order.component.css']
})
export class CreateOrderComponent {
  shakesList:Shakes[]=[];
  selectedNameShake:string="";
  selectedSizeShake:number=0;
  maxSumShakes:number=10;
  shakesOrderWithPrice:ShakeForOrder[]=[];
  sumPriceAllShakesList:number=0;
  shake_order:Shakes=this.shakesList[0];
  shake:any;

  selectedClientName:string="";
  allPrice:number=0;
  form:FormGroup=new FormGroup({});
  orderList:Orders[]=[];
  order:Orders=this.orderList[0];

  constructor(private shakes:ShakeService,private orders_s:OrderService){
    this.shakes.getAllShakes().subscribe((shakes:Shakes[])=>{
    this.shakesList=shakes;})
    this.maxSumShakes=10;
    this.allPrice=orders_s.getSumPriceAllShakesList();
    this.shakesOrderWithPrice=orders_s.getShakeForOrder();
  }

  ngOnInit(){
    this.form=new FormGroup({
      clientName:new FormControl("")
    });
  }

  onSubmit(form:FormGroup){

    var clientName:string=form.value.clientName;
    var shakesOrder:ShakeForOrder[]=this.shakesOrderWithPrice;
    var price:number=this.allPrice;
    this.order=new Orders(clientName,shakesOrder,price);
    this.orders_s.createOrder(this.order);

    this.orders_s.sumPriceAllShakesList=0;
    this.orders_s.shakesOrderWithPrice=[];
    
    }
  }



 

// }
