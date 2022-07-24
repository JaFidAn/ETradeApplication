import { Component } from '@angular/core';
import { CustomToastrService, ToastrMessagePosition, ToastrMessageType } from './services/ui/custom-toastr.service';
declare var $: any;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'client-app';

  constructor(private toastrService: CustomToastrService) {
    toastrService.message("Salam", "Rasim", {
      messageType: ToastrMessageType.Info,
      toastrMessagePosition: ToastrMessagePosition.TopRight
    })
  }

}


