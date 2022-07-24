import { Component, OnInit } from '@angular/core';
import { AlertifyService, MessagePosition, MessageType } from 'src/app/services/admin/alertify.service';


@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.scss']
})
export class LayoutComponent implements OnInit {

  constructor(private alertifyService: AlertifyService) { }

  ngOnInit(): void {
   this.alertifyService.message("Salam", {messageType: MessageType.Success, delay: 3, messagePosition: MessagePosition.BottomRight})
  }

}
