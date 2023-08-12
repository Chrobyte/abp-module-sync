using Cb.Samples.CustomerManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Cb.Samples.CustomerManagement.Pages;

public abstract class CustomerManagementPageModel : AbpPageModel
{
    protected CustomerManagementPageModel()
    {
        LocalizationResourceType = typeof(CustomerManagementResource);
    }
}
