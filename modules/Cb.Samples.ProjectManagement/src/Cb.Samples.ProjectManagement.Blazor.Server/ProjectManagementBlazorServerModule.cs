using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Cb.Samples.ProjectManagement.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(ProjectManagementBlazorModule)
    )]
public class ProjectManagementBlazorServerModule : AbpModule
{

}
