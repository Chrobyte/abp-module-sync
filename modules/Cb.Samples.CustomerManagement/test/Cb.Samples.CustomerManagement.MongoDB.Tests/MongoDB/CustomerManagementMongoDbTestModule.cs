using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace Cb.Samples.CustomerManagement.MongoDB;

[DependsOn(
    typeof(CustomerManagementTestBaseModule),
    typeof(CustomerManagementMongoDbModule)
    )]
public class CustomerManagementMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
