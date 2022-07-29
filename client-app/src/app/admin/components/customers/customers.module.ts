import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomersComponent } from './customers.component';
import { FileUploadModule } from 'src/app/services/common/file-upload/file-upload.module';



@NgModule({
  declarations: [
    CustomersComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path: "", component: CustomersComponent}
    ])
  ]
})
export class CustomersModule { }
