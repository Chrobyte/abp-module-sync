using Cb.Samples.ModulesEntitySync.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Cb.Samples.ModulesEntitySync.Blazor;

public abstract class ModulesEntitySyncComponentBase : AbpComponentBase
{
    protected ModulesEntitySyncComponentBase()
    {
        LocalizationResource = typeof(ModulesEntitySyncResource);
    }
}
