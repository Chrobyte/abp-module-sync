using Volo.Abp.Bundling;

namespace Cb.Samples.ProjectManagement.Blazor.Host;

public class ProjectManagementBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
