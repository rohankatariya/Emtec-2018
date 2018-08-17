import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.css']
})
export class DeleteComponent implements OnInit {
  @Input() deleteId : number;
  constructor() { }

  ngOnInit() {
  }
  delete()
  {

  }

}
