import { HttpClientService } from './../../../services/common/http-client.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { Component, OnInit } from '@angular/core';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';
import { Create_Product } from 'src/app/contracts/create_product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent extends BaseComponent implements OnInit {

  constructor(spinner: NgxSpinnerService, private httpClientService: HttpClientService) {
    super(spinner)
   }

  ngOnInit(): void {
    this.showSpinner(SpinnerType.BallAtom)

    // this.httpClientService.get<Create_Product[]>({
    //   controller: "products"
    // }).subscribe(data => console.log(data));

    // this.httpClientService.post({
    //   controller: "products"
    // }, {
    //   name: "Kitab",
    //   stock: 50,
    //   price: 25.50
    // }).subscribe();

    // this.httpClientService.put({
    //   controller: "products"
    // }, {
    //   id: "07a358a3-726d-43bd-0142-08da6dbe1eb9",
    //   name: "Rengli kitab",
    //   stock: 200,
    //   price: 35.5
    // }).subscribe();

  //   this.httpClientService.delete({
  //     controller: "products"
  //   }, 
  //     "31826eb6-9808-4ae6-891a-08da6bba2611"
  //   ).subscribe();

    // From Fake RestApi
  // this.httpClientService.get({
  //   fullEndPoint: "https://jsonplaceholder.typicode.com/posts"
  // }).subscribe(data => console.log(data));

  }

}
