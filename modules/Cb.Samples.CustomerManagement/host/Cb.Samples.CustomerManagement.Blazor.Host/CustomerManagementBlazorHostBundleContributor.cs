using Volo.Abp.Bundling;

namespace Cb.Samples.CustomerManagement.Blazor.Host;

public class CustomerManagementBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
