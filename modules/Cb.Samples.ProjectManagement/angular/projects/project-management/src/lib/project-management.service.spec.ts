import { TestBed } from '@angular/core/testing';
import { ProjectManagementService } from './services/project-management.service';
import { RestService } from '@abp/ng.core';

describe('ProjectManagementService', () => {
  let service: ProjectManagementService;
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
    service = TestBed.inject(ProjectManagementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
