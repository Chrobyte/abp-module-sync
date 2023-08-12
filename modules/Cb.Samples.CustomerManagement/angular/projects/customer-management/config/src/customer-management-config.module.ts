import { ModuleWithProviders, NgModule } from '@angular/core';
import { CUSTOMER_MANAGEMENT_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class CustomerManagementConfigModule {
  static forRoot(): ModuleWithProviders<CustomerManagementConfigModule> {
    return {
      ngModule: CustomerManagementConfigModule,
      providers: [CUSTOMER_MANAGEMENT_ROUTE_PROVIDERS],
    };
  }
}
