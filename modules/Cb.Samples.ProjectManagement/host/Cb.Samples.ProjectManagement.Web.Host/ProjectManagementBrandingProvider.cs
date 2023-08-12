using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Cb.Samples.ProjectManagement;

[Dependency(ReplaceServices = true)]
public class ProjectManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProjectManagement";
}
