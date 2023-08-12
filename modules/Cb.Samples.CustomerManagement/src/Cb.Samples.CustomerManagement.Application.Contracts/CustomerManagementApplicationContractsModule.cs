using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Cb.Samples.CustomerManagement;

[DependsOn(
    typeof(CustomerManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class CustomerManagementApplicationContractsModule : AbpModule
{

}
