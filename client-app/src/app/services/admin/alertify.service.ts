import { Injectable } from '@angular/core';
declare var alertify: any;

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor() { }

  // message(message: string, messageType: MessageType, messagePosition: MessagePosition, delay : number = 3) {
  message(message: string, alertifyOptions: ALertifyOptions) {
    alertify.set('notifier','delay', alertifyOptions.delay);
    alertify.set('notifier','position', alertifyOptions.messagePosition);
    alertify[alertifyOptions.messageType](message);
  }
}

export class ALertifyOptions {
  messageType: MessageType
  messagePosition: MessagePosition
  delay?: number
}

export enum MessageType {
  Error = "error",
  Message = "message",
  Notify = "notify",
  Success = "success",
  Warning = "warning"
}


export enum MessagePosition {
  TopCenter = "top-center",
  TopLeft = "top-left",
  TopRight = "top-right",
  BottomCenter = "bottom-center",
  BottomLeft = "bottom-left",
  BottomRight = "bottom-right"
}