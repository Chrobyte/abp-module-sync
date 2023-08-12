using Volo.Abp.Modularity;

namespace Cb.Samples.CustomerManagement;

[DependsOn(
    typeof(CustomerManagementApplicationModule),
    typeof(CustomerManagementDomainTestModule)
    )]
public class CustomerManagementApplicationTestModule : AbpModule
{

}
