import { Sales } from "./sales";
import { ShakeForOrder } from "./shakeForOrder";

export class Orders{
  constructor(public clientName:string,public ShakesWithPrice:ShakeForOrder[],public sumPriceAllShakesList:number){}
}
