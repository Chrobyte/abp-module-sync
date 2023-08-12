import { TestBed } from '@angular/core/testing';
import { CustomerManagementService } from './services/customer-management.service';
import { RestService } from '@abp/ng.core';

describe('CustomerManagementService', () => {
  let service: CustomerManagementService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(CustomerManagementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
