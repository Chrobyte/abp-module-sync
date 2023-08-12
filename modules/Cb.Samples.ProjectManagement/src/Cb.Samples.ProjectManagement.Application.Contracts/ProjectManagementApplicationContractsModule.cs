using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Cb.Samples.ProjectManagement;

[DependsOn(
    typeof(ProjectManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ProjectManagementApplicationContractsModule : AbpModule
{

}
