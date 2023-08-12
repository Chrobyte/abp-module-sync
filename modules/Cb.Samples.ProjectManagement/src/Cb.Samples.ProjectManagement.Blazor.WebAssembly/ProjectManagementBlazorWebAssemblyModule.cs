using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Cb.Samples.ProjectManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(ProjectManagementBlazorModule),
    typeof(ProjectManagementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class ProjectManagementBlazorWebAssemblyModule : AbpModule
{

}
