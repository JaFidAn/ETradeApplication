import { HttpClientService } from './../../services/common/http-client.service';
import { SpinnerType } from 'src/app/base/base.component';
import { NgxSpinnerService } from 'ngx-spinner';
import { Directive, ElementRef, EventEmitter, HostListener, Input, Output, Renderer2 } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DeleteDialogComponent, DeleteState } from 'src/app/dialogs/delete-dialog/delete-dialog.component';

declare var $: any;

@Directive({
  selector: '[appDelete]'
})
export class DeleteDirective {

  constructor(
    private element: ElementRef,
    private _renderer: Renderer2,
    private htttpClientService: HttpClientService,
    private spinner: NgxSpinnerService,
    public dialog: MatDialog
    ) {
      const img = _renderer.createElement("img");
      img.setAttribute("src", "../../../../../assets/delete.png");
      img.setAttribute("style", "cursor: pointer;");
      img.width = 25;
      img.height = 25;

      _renderer.appendChild(element.nativeElement, img);
    }

    @Input() id: string;
    @Input() controller: string;
    @Output() callback: EventEmitter<any> = new EventEmitter;

    @HostListener("click")

    async onClick() {
      this.openDialog(async () => {
        this.spinner.show(SpinnerType.BallAtom);
        const td: HTMLTableCellElement = this.element.nativeElement;
        this.htttpClientService.delete({
          controller: this.controller
        }, this.id).subscribe(data => {
          $(td.parentElement).fadeOut(1000, ()=> {
            this.callback.emit();
          });
        })
        
      })
    
    }

    openDialog(afterClosed: any): void {
      const dialogRef = this.dialog.open(DeleteDialogComponent, {
        width: '250px',
        data: DeleteState.Yes
      });
  
      dialogRef.afterClosed().subscribe(result => {
        if(result == DeleteState.Yes) 
          afterClosed();
      });
    }
}
