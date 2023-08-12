using Cb.Samples.ProjectManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Cb.Samples.ProjectManagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ProjectManagementPageModel : AbpPageModel
{
    protected ProjectManagementPageModel()
    {
        LocalizationResourceType = typeof(ProjectManagementResource);
        ObjectMapperContext = typeof(ProjectManagementWebModule);
    }
}
