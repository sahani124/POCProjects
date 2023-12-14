import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';


import { NgModule } from '@angular/core';
import {FormsModule , ReactiveFormsModule} from "@angular/forms"

import {CustomerComponent } from './CustomerApp.CustomerComponent';
import {GridComponent} from "../Utility/CustomerApp.GridComponent"
import { CustomerRoutes } from '../Routing/CustomerApp.CustomerRouting';
import {HttpClientModule,HTTP_INTERCEPTORS} from "@angular/common/http"
import { MyInterceptor } from '../Utility/Utility.HttpInterceptor';

import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@NgModule({
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  declarations: [
     CustomerComponent , GridComponent
  ],
  imports: [
    RouterModule.forChild(CustomerRoutes),
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
  bootstrap: [CustomerComponent]
})
export class CustomerModule { }
