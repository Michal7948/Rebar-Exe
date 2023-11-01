import { Component } from '@angular/core';
import { Shakes } from '../model/shake';
import { ShakeService } from '../services/shake.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent {

  shakesList:Shakes[]=[];
  
  constructor(private shakes:ShakeService){
    this.shakes.getAllShakes().subscribe((shakes:Shakes[])=>{
    this.shakesList=shakes;})
  }

}
