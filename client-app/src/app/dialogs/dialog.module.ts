import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatDialogModule} from '@angular/material/dialog';
import { DeleteDialogComponent } from './delete-dialog/delete-dialog.component';
import { FileUploadComponent } from '../services/common/file-upload/file-upload.component';
import { FileUploadModule } from '../services/common/file-upload/file-upload.module';



@NgModule({
  declarations: [
    DeleteDialogComponent
  ],
  imports: [
    CommonModule,
    MatDialogModule,
    FileUploadModule
  ]
})
export class DialogModule { }
