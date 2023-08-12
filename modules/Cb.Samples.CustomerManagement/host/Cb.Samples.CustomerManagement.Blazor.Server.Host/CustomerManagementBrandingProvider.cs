using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Cb.Samples.CustomerManagement.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class CustomerManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CustomerManagement";
}
