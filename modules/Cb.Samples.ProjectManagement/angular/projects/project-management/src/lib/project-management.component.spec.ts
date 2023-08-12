import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { ProjectManagementComponent } from './components/project-management.component';
import { ProjectManagementService } from '@cb.Samples/project-management';
import { of } from 'rxjs';

describe('ProjectManagementComponent', () => {
  let component: ProjectManagementComponent;
  let fixture: ComponentFixture<ProjectManagementComponent>;
  const mockProjectManagementService = jasmine.createSpyObj('ProjectManagementService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ProjectManagementComponent],
      providers: [
        {
          provide: ProjectManagementService,
          useValue: mockProjectManagementService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
