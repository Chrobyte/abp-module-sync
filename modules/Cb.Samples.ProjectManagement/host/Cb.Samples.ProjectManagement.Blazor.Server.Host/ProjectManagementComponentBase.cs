using Cb.Samples.ProjectManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Cb.Samples.ProjectManagement.Blazor.Server.Host;

public abstract class ProjectManagementComponentBase : AbpComponentBase
{
    protected ProjectManagementComponentBase()
    {
        LocalizationResource = typeof(ProjectManagementResource);
    }
}
