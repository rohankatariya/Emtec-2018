import { Injectable } from '@angular/core';
import { Employee } from './Employee';
import { Observable ,of} from 'rxjs';
import { employees } from '../app/Employees';
@Injectable({
  providedIn: 'root'
})
export class EmployeeManagerServicesService {

  constructor() { }
  getAllEmployees():Observable<Employee[]>
  {
    return of(employees);
  }
  getEmployeeById():Observable<Employee>
  {
     return of();
  }
  Insert():Observable<Employee[]>
  {
    return of(employees);
  }
  Update():Observable<Employee[]>
  {
    return of(employees);
  }
  Delete():Observable<Employee[]>
  {
    return of(employees);
  }
}
