using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Cb.Samples.CustomerManagement;

[DependsOn(
    typeof(CustomerManagementApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class CustomerManagementHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(CustomerManagementApplicationContractsModule).Assembly,
            CustomerManagementRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CustomerManagementHttpApiClientModule>();
        });

    }
}
