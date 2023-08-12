using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Cb.Samples.CustomerManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CustomerManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class CustomerManagementConsoleApiClientModule : AbpModule
{

}
