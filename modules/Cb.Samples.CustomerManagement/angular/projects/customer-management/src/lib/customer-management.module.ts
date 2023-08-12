import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CustomerManagementComponent } from './components/customer-management.component';
import { CustomerManagementRoutingModule } from './customer-management-routing.module';

@NgModule({
  declarations: [CustomerManagementComponent],
  imports: [CoreModule, ThemeSharedModule, CustomerManagementRoutingModule],
  exports: [CustomerManagementComponent],
})
export class CustomerManagementModule {
  static forChild(): ModuleWithProviders<CustomerManagementModule> {
    return {
      ngModule: CustomerManagementModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<CustomerManagementModule> {
    return new LazyModuleFactory(CustomerManagementModule.forChild());
  }
}
