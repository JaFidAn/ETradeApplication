import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class CustomToastrService {

  constructor(private toastr: ToastrService) { }

  // (messagmessagee: string, title: string, messageType: ToastrMessageType, toastrMessagePosition: ToastrMessagePosition) {
  message(message: string, title: string, toastrOptions: Partial<ToastrOptions>) {
    this.toastr[toastrOptions.messageType!] (message, title, {positionClass: toastrOptions.toastrMessagePosition})
  }
}

export class ToastrOptions {
  messageType: ToastrMessageType = ToastrMessageType.Success
  toastrMessagePosition: ToastrMessagePosition = ToastrMessagePosition.BottomRight
}

export enum ToastrMessageType {
  Success = "success",
  Info = "info",
  Warning = "warning",
  Error = "error"
}

export enum ToastrMessagePosition {
  TopCenter = "toast-top-center",
  TopLeft = "toast-top-left",
  TopRight = "toast-top-right",
  TopFullWidth = "toast-top-full-width",
  BottomCenter = "toast-bottom-center",
  BottomLeft = "toast-bottom-left",
  BottomRight = "toast-bottom-right",
  BottomFullWidth = "toast-bottom-full-width"
}
