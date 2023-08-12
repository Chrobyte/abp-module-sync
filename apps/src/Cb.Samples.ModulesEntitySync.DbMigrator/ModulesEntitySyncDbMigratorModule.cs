using Cb.Samples.ModulesEntitySync.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Cb.Samples.ModulesEntitySync.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ModulesEntitySyncEntityFrameworkCoreModule),
    typeof(ModulesEntitySyncApplicationContractsModule)
    )]
public class ModulesEntitySyncDbMigratorModule : AbpModule
{
}
