import { ModuleWithProviders, NgModule } from '@angular/core';
import { PROJECT_MANAGEMENT_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class ProjectManagementConfigModule {
  static forRoot(): ModuleWithProviders<ProjectManagementConfigModule> {
    return {
      ngModule: ProjectManagementConfigModule,
      providers: [PROJECT_MANAGEMENT_ROUTE_PROVIDERS],
    };
  }
}
