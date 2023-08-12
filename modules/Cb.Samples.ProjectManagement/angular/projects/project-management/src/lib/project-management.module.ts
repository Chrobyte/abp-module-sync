import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { ProjectManagementComponent } from './components/project-management.component';
import { ProjectManagementRoutingModule } from './project-management-routing.module';

@NgModule({
  declarations: [ProjectManagementComponent],
  imports: [CoreModule, ThemeSharedModule, ProjectManagementRoutingModule],
  exports: [ProjectManagementComponent],
})
export class ProjectManagementModule {
  static forChild(): ModuleWithProviders<ProjectManagementModule> {
    return {
      ngModule: ProjectManagementModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<ProjectManagementModule> {
    return new LazyModuleFactory(ProjectManagementModule.forChild());
  }
}
