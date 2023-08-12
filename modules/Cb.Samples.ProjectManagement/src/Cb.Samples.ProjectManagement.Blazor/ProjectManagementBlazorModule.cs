using Microsoft.Extensions.DependencyInjection;
using Cb.Samples.ProjectManagement.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Cb.Samples.ProjectManagement.Blazor;

[DependsOn(
    typeof(ProjectManagementApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class ProjectManagementBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<ProjectManagementBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<ProjectManagementBlazorAutoMapperProfile>(validate: false);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new ProjectManagementMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(ProjectManagementBlazorModule).Assembly);
        });
    }
}
