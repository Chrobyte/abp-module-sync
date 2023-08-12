using Cb.Samples.ModulesEntitySync.CustomerSync;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace Cb.Samples.ModulesEntitySync;

[DependsOn(
    typeof(ModulesEntitySyncDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(ModulesEntitySyncApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
[DependsOn(
    typeof(CustomerManagement.CustomerManagementApplicationModule),
    typeof(ProjectManagement.ProjectManagementApplicationModule)
)]
public class ModulesEntitySyncApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<ModulesEntitySyncApplicationModule>();
        });

        Configure<AbpDistributedEntityEventOptions>(options =>
        {
            options.AutoEventSelectors.Add<CustomerManagement.Customers.Customer>();
            options.EtoMappings.Add<CustomerManagement.Customers.Customer, CmCustomerEto>();

            options.AutoEventSelectors.Add<ProjectManagement.Customers.Customer>();
            options.EtoMappings.Add<ProjectManagement.Customers.Customer, PmCustomerEto>();
        });
    }
}
