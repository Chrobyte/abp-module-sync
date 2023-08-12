using Localization.Resources.AbpUi;
using Cb.Samples.CustomerManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Cb.Samples.CustomerManagement;

[DependsOn(
    typeof(CustomerManagementApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class CustomerManagementHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(CustomerManagementHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<CustomerManagementResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
