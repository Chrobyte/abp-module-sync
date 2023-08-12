using Cb.Samples.CustomerManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Cb.Samples.CustomerManagement.Blazor.Server.Host;

public abstract class CustomerManagementComponentBase : AbpComponentBase
{
    protected CustomerManagementComponentBase()
    {
        LocalizationResource = typeof(CustomerManagementResource);
    }
}
