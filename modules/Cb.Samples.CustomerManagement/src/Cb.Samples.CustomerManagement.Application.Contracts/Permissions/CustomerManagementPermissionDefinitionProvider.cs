using Cb.Samples.CustomerManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Cb.Samples.CustomerManagement.Permissions;

public class CustomerManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CustomerManagementPermissions.GroupName, L("Permission:CustomerManagement"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomerManagementResource>(name);
    }
}
