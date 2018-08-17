import { TestBed, inject } from '@angular/core/testing';

import { EmployeeManagerServicesService } from './EmployeeManager-services.service';

describe('EmployeeServicesService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [EmployeeManagerServicesService]
    });
  });

  it('should be created', inject([EmployeeManagerServicesService], (service: EmployeeManagerServicesService) => {
    expect(service).toBeTruthy();
  }));
});
