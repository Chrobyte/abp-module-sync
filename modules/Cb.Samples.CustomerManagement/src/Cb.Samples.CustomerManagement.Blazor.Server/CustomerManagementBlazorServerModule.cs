using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Cb.Samples.CustomerManagement.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(CustomerManagementBlazorModule)
    )]
public class CustomerManagementBlazorServerModule : AbpModule
{

}
