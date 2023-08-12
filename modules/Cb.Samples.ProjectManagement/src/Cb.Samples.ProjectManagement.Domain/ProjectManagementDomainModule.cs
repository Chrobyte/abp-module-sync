using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Cb.Samples.ProjectManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ProjectManagementDomainSharedModule)
)]
public class ProjectManagementDomainModule : AbpModule
{

}
