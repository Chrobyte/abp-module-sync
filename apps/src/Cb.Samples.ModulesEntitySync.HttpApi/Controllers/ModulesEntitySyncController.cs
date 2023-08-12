using Cb.Samples.ModulesEntitySync.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cb.Samples.ModulesEntitySync.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ModulesEntitySyncController : AbpControllerBase
{
    protected ModulesEntitySyncController()
    {
        LocalizationResource = typeof(ModulesEntitySyncResource);
    }
}
