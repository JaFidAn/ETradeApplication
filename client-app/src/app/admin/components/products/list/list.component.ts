import { NgxSpinnerService } from 'ngx-spinner';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { List_Product } from 'src/app/contracts/list_product';
import { ProductService } from 'src/app/services/common/models/product.service';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';
import { AlertifyService, MessagePosition, MessageType } from 'src/app/services/admin/alertify.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent extends BaseComponent implements OnInit {
  

  constructor(spinner: NgxSpinnerService, private productService: ProductService, private alertifyService: AlertifyService) {
    super(spinner);
   }

  displayedColumns: string[] = ['name', 'stock', 'price', 'createdDate', 'edit', 'delete'];
  
  dataSource: MatTableDataSource<List_Product> = null ;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  async getProducts() {
    this.showSpinner(SpinnerType.BallAtom);
    const allProducts: {totalCount: number; products: List_Product[]} = await this.productService.read(this.paginator ? this.paginator.pageIndex : 0,
      this.paginator ? this.paginator.pageSize : 5,() => this.hideSpinner(SpinnerType.BallAtom), errorMessage => 
      this.alertifyService.message(errorMessage, {
      messageType: MessageType.Error,
      messagePosition: MessagePosition.TopRight
    }))
    this.dataSource = new MatTableDataSource<List_Product>(allProducts.products);
    this.paginator.length = allProducts.totalCount;
  }

  async pageChanged() {
    await this.getProducts();
  }

  delete(id) {
    alert(id)
  }


  async ngOnInit() {
    await this.getProducts();
  }

}
