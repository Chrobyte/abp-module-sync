using Cb.Samples.CustomerManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cb.Samples.CustomerManagement;

public abstract class CustomerManagementController : AbpControllerBase
{
    protected CustomerManagementController()
    {
        LocalizationResource = typeof(CustomerManagementResource);
    }
}
