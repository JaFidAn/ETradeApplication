import { CustomToastrService, ToastrOptions, ToastrMessageType, ToastrMessagePosition } from './../../../services/ui/custom-toastr.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { Component, OnInit } from '@angular/core';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent extends BaseComponent implements OnInit {

  constructor(spinner: NgxSpinnerService, private toastrService: CustomToastrService) { 
    super(spinner)
  }

  ngOnInit(): void {
    this.showSpinner(SpinnerType.BallAtom)
    this.toastrService.message("Rasim", "Salam", {
     messageType: ToastrMessageType.Info,
     toastrMessagePosition: ToastrMessagePosition.TopRight
    })
  }

}
