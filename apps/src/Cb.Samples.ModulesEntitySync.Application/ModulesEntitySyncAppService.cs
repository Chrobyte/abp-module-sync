using System;
using System.Collections.Generic;
using System.Text;
using Cb.Samples.ModulesEntitySync.Localization;
using Volo.Abp.Application.Services;

namespace Cb.Samples.ModulesEntitySync;

/* Inherit your application services from this class.
 */
public abstract class ModulesEntitySyncAppService : ApplicationService
{
    protected ModulesEntitySyncAppService()
    {
        LocalizationResource = typeof(ModulesEntitySyncResource);
    }
}
