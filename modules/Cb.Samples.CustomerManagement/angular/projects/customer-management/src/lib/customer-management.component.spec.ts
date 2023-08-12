import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { CustomerManagementComponent } from './components/customer-management.component';
import { CustomerManagementService } from '@cb.Samples/customer-management';
import { of } from 'rxjs';

describe('CustomerManagementComponent', () => {
  let component: CustomerManagementComponent;
  let fixture: ComponentFixture<CustomerManagementComponent>;
  const mockCustomerManagementService = jasmine.createSpyObj('CustomerManagementService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [CustomerManagementComponent],
      providers: [
        {
          provide: CustomerManagementService,
          useValue: mockCustomerManagementService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomerManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
