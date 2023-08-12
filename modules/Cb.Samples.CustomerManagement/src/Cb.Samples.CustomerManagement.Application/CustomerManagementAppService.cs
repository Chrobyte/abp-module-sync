using Cb.Samples.CustomerManagement.Localization;
using Volo.Abp.Application.Services;

namespace Cb.Samples.CustomerManagement;

public abstract class CustomerManagementAppService : ApplicationService
{
    protected CustomerManagementAppService()
    {
        LocalizationResource = typeof(CustomerManagementResource);
        ObjectMapperContext = typeof(CustomerManagementApplicationModule);
    }
}
