import { Component, OnInit } from '@angular/core';
import { ProjectManagementService } from '../services/project-management.service';

@Component({
  selector: 'lib-project-management',
  template: ` <p>project-management works!</p> `,
  styles: [],
})
export class ProjectManagementComponent implements OnInit {
  constructor(private service: ProjectManagementService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
