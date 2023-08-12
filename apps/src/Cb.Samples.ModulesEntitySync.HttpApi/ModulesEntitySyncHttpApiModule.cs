﻿using Localization.Resources.AbpUi;
using Cb.Samples.ModulesEntitySync.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace Cb.Samples.ModulesEntitySync;

[DependsOn(
    typeof(ModulesEntitySyncApplicationContractsModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
[DependsOn(
    typeof(CustomerManagement.CustomerManagementHttpApiModule),
    typeof(ProjectManagement.ProjectManagementHttpApiModule)
)]
public class ModulesEntitySyncHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ModulesEntitySyncResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
