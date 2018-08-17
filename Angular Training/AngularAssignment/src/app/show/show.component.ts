import { Component, OnInit } from '@angular/core';
import { Employee } from '../Employee';
import { EmployeeManagerServicesService } from '../EmployeeManager-services.service'
@Component({
  selector: 'app-show',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.css']
})
export class ShowComponent implements OnInit {
  employ : Employee[] = [  ];
  update : Employee = null;
  deleteId : number ;
  constructor(
    private employeeManager: EmployeeManagerServicesService
  ) { }

  ngOnInit() {
    this.getAllEmployees();
  }
  getAllEmployees()
  {
    this.employeeManager.getAllEmployees().subscribe(employee => this.employ=employee);
  }
  deleteById(employeeId : number)
  {
    this.deleteId = employeeId;
  }
  edit(employee : Employee)
  {
    this.update=employee;
  }
}
