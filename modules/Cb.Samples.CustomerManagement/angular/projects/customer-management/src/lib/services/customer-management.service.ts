import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class CustomerManagementService {
  apiName = 'CustomerManagement';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/CustomerManagement/sample' },
      { apiName: this.apiName }
    );
  }
}
