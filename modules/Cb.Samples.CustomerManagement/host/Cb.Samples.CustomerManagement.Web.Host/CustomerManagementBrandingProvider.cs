using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Cb.Samples.CustomerManagement;

[Dependency(ReplaceServices = true)]
public class CustomerManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CustomerManagement";
}
