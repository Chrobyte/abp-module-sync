using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Cb.Samples.ProjectManagement.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class ProjectManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProjectManagement";
}
