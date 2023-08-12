using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Cb.Samples.CustomerManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(CustomerManagementBlazorModule),
    typeof(CustomerManagementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class CustomerManagementBlazorWebAssemblyModule : AbpModule
{

}
