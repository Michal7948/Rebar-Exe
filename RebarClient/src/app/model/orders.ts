import { Sales } from "./sales";
import { ShakeForOrder } from "./shakeForOrder";

export class Orders{
  constructor(public clientName:string,public ShakesWithPrice:ShakeForOrder[],public sumPriceAllShakesList:number){}
}

// export class Orders{
//   constructor(public id:string ,public clientName:string,public ShakesWithPrice:ShakeForOrder[],public sumPriceAllShakesList:number,public dateOrder:Date,public sales:Sales[]){}
// }