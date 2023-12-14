import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { NgModule } from '@angular/core';
import {FormsModule , ReactiveFormsModule} from "@angular/forms"
import { UserComponent} from './CustomerApp.LoginComponent';
import {GridComponent} from "../Utility/CustomerApp.GridComponent"
import {UserRoutes  } from '../Routing/CustomerApp.LoginRouting';
import {HttpClientModule,HTTP_INTERCEPTORS} from "@angular/common/http"
import { MyInterceptor } from '../Utility/Utility.HttpInterceptor';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@NgModule({
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  declarations: [
     UserComponent ,GridComponent
  ],
  imports: [
    RouterModule.forChild(UserRoutes),
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  exports: [
    GridComponent
  ],
  providers: [
   {provide: HTTP_INTERCEPTORS, useClass: MyInterceptor , 
  multi:true}

  ],
  bootstrap: [UserComponent]
})
export class UserModule { }
