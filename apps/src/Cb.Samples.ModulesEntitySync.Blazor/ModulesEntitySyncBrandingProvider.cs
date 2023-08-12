using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Cb.Samples.ModulesEntitySync.Blazor;

[Dependency(ReplaceServices = true)]
public class ModulesEntitySyncBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ModulesEntitySync";
}
