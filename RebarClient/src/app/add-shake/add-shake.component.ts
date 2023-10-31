import { Component } from '@angular/core';
import { Shakes } from '../model/shake';
import { FormControl, FormGroup } from '@angular/forms';
import { ShakeService } from '../services/shake.service';

@Component({
  selector: 'app-add-shake',
  templateUrl: './add-shake.component.html',
  styleUrls: ['./add-shake.component.css']
})
export class AddShakeComponent {
  shake:Shakes;
  form:FormGroup=new FormGroup({});
  //idNumberForm="";
  shakesList:Shakes[]=[];
  idExists=false;
  
  constructor(private shakes_s:ShakeService) {
    this.shake=shakes_s.shakesList[0];
    this.shakes_s.getAllShakes().subscribe((shakes: Shakes[]) => {this.shakesList = shakes;});
  }

  ngOnInit(){
    this.form=new FormGroup({
      name:new FormControl("") ,
      description:new FormControl(""),
      priceSizeS:new FormControl(),
      priceSizeM:new FormControl(),
      priceSizeL:new FormControl()
    });
  }

  onSubmit(form:FormGroup){
    var shake_json = JSON.stringify(form);
    this.shakes_s.createShake(shake_json);
  }
}
