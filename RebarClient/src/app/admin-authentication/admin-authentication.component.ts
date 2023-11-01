import { Component } from '@angular/core';

@Component({
  selector: 'app-admin-authentication',
  templateUrl: './admin-authentication.component.html',
  styleUrls: ['./admin-authentication.component.css']
})
export class AdminAuthenticationComponent {
  passwordAdmin:string="123456";
  passwordInput:string="";
  samePassword:boolean=false;

  checkPassword(){
    if (this.passwordAdmin!=this.passwordInput) {
      alert("Incorrect password\nTry again");
    }
    else {
      this.samePassword=true;
    }
  }
  
  

}
