import { Component , Injector  } from '@angular/core';
import {User} from "./CustomerApp.Usermodel";
import {BaseLogger} from "../Utility/CustomerApp.Logger";
import {HttpClient} from "@angular/common/http";
//import {HttpClient} from "@angular/common/"
@Component({
  templateUrl: './CustomerApp.LoginView.html'
})
export  class UserComponent {
  title = 'CustomerApplication';
  UserModel : User = new User();
  //CustomerModels :Array<Customer> = new Array<Customer>();
  Logobj : BaseLogger = null;
  Disable:boolean = false;
  constructor(_injector:Injector, public httpc:HttpClient ){
    this.Logobj = _injector.get("1");
    this.Logobj.Log();
  }
  PosttoServer(){
    //http://localhost:3000/Customers
    // create a light weight DTO Data transfer object
    this.Disable = true;
    var Userdto: any = {};
    Userdto.UserId = this.UserModel.UserId;
    Userdto.UserName = this.UserModel.UserName;
    Userdto.UserPIN = this.UserModel.UserPIN;
    //this.httpc.get()
    // this.httpc.get("http://localhost/MISDashBoard/api/values/",{headers: 
    // {'Content-Type': 'application/json', 'Access-Control-Allow-Origin': '*' } }).subscribe(res => this.SuccessGet(res),
    // res=>this.Error(res)); // Require API call.

    this.httpc.get("/api/values/").
    subscribe(res=>this.SuccessGet(res),res=>this.Error(res));
  }
  GetFromServer(){
    var Userdto: any = {};
    Userdto.UserId = this.UserModel.UserId;
    Userdto.UserName = this.UserModel.UserName;
    Userdto.UserPIN = this.UserModel.UserPIN;
    
    this.httpc.post("/api/values/Login",Userdto).
    subscribe(res=>this.Success(res),res=>this.Error(res));
  }
  Error(res) {
   alert(res)
  }
  Success(res) {
   alert(res)
  }
  SuccessGet(res) {
    this.UserModel = res;
    this.Disable = false;
    this.UserModel = new User();

    alert(res);
  }
  // SelectCustomer(_selected:Customer){
  //   this.CustomerModel = _selected;
    
  // }
  // Add(){
  //   this.CustomerModels.push(this.CustomerModel);
  //   this.CustomerModel = new Customer();// clear UI
  // }
  
  // hasError(typeofvalidator:string,
  //       controlname:string) : boolean{
  //         return this.CustomerModel
  //               .formCustomerGroup
  //               .controls[controlname]
  //               .hasError(typeofvalidator);
  // }
}

