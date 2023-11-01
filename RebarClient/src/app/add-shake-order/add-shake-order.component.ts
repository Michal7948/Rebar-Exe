import { Component } from '@angular/core';
import { Shakes } from '../model/shake';
import { ShakeForOrder } from '../model/shakeForOrder';
import { ShakeService } from '../services/shake.service';
import { FormGroup, FormControl } from '@angular/forms';
import { OrderService } from '../services/order.service';

@Component({
  selector: 'app-add-shake-order',
  templateUrl: './add-shake-order.component.html',
  styleUrls: ['./add-shake-order.component.css']
})
export class AddShakeOrderComponent {
  shakesList:Shakes[]=[];
  maxSumShakes:number=10;
  shakesOrderWithPrice:ShakeForOrder[]=[];
  shakesOrder:ShakeForOrder=this.shakesOrderWithPrice[0];
  shake:any;

  form:FormGroup=new FormGroup({});


  constructor(private shakes:ShakeService,private orders_s:OrderService){
    this.shakes.getAllShakes().subscribe((shakes:Shakes[])=>{
    this.shakesList=shakes;})
    this.maxSumShakes=10;
  }



  ngOnInit(){
    this.form=new FormGroup({
      shakeName:new FormControl("") ,
      shakeSize:new FormControl(),
      shakeAmount:new FormControl()
    });
  }

  onSubmit(form:FormGroup){
    if(this.maxSumShakes<form.value.shakeAmount){
      alert("You exceeded the limit!\nYou can order up to 10 shakes");
    }
    else{
      this.maxSumShakes-=form.value.shakeAmount;
      this.orders_s.setSumPriceAllShakesList(form.value.shakeSize);
      this.shake=this.shakes.getShakeById(form.value.shakeName);
      this.shakesOrder=new ShakeForOrder(this.shake,form.value.shakeAmount)
      this.orders_s.addShakeForOrder(this.shakesOrder);
    }
  }

}
