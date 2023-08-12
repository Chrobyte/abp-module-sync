using Cb.Samples.ModulesEntitySync.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Cb.Samples.ModulesEntitySync;

[DependsOn(
    typeof(ModulesEntitySyncEntityFrameworkCoreTestModule)
    )]
public class ModulesEntitySyncDomainTestModule : AbpModule
{

}
