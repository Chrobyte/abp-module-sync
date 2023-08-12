using Cb.Samples.ProjectManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Cb.Samples.ProjectManagement.Pages;

public abstract class ProjectManagementPageModel : AbpPageModel
{
    protected ProjectManagementPageModel()
    {
        LocalizationResourceType = typeof(ProjectManagementResource);
    }
}
