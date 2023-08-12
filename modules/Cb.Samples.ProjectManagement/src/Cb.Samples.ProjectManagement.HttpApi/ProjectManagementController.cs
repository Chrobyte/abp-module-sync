using Cb.Samples.ProjectManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cb.Samples.ProjectManagement;

public abstract class ProjectManagementController : AbpControllerBase
{
    protected ProjectManagementController()
    {
        LocalizationResource = typeof(ProjectManagementResource);
    }
}
