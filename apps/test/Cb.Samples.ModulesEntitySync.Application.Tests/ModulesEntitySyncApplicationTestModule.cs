using Volo.Abp.Modularity;

namespace Cb.Samples.ModulesEntitySync;

[DependsOn(
    typeof(ModulesEntitySyncApplicationModule),
    typeof(ModulesEntitySyncDomainTestModule)
    )]
public class ModulesEntitySyncApplicationTestModule : AbpModule
{

}
