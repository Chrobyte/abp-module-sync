using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace Cb.Samples.ProjectManagement.MongoDB;

[DependsOn(
    typeof(ProjectManagementTestBaseModule),
    typeof(ProjectManagementMongoDbModule)
    )]
public class ProjectManagementMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
