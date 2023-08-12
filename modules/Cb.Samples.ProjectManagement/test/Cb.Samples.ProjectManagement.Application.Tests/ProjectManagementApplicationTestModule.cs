using Volo.Abp.Modularity;

namespace Cb.Samples.ProjectManagement;

[DependsOn(
    typeof(ProjectManagementApplicationModule),
    typeof(ProjectManagementDomainTestModule)
    )]
public class ProjectManagementApplicationTestModule : AbpModule
{

}
