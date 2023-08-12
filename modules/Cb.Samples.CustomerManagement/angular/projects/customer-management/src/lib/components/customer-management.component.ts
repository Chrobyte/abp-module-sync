import { Component, OnInit } from '@angular/core';
import { CustomerManagementService } from '../services/customer-management.service';

@Component({
  selector: 'lib-customer-management',
  template: ` <p>customer-management works!</p> `,
  styles: [],
})
export class CustomerManagementComponent implements OnInit {
  constructor(private service: CustomerManagementService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
