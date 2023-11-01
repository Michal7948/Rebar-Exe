import { Injectable } from '@angular/core';
import { Orders } from '../model/orders';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ShakeForOrder } from '../model/shakeForOrder';

@Injectable({
  providedIn: 'root'
})
export class OrderService {



   private baseUrl = 'http://localhost:5179/api/Order';
   ordersList: Orders[] = [];
   shakesOrderWithPrice:ShakeForOrder[]=[];
   sumPriceAllShakesList:number=0;
  constructor(private http: HttpClient) {}

  getAllOrders(): Observable<Orders[]> {
    return this.http.get<Orders[]>(this.baseUrl);
  }

  getOrderById(id: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }


  createOrder(order: any): Observable<any> {
    console.log(order);
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' })};
    return this.http.post(this.baseUrl,order,httpOptions);
  }


  addShakeForOrder(shake:ShakeForOrder){
    this.shakesOrderWithPrice.push(shake);
  }

  getShakeForOrder(){
    return this.shakesOrderWithPrice;
  }

  setSumPriceAllShakesList(price:number){
    this.sumPriceAllShakesList+=price;
  }

  getSumPriceAllShakesList(){
    return this.sumPriceAllShakesList;
  }
}
