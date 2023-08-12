using Cb.Samples.ModulesEntitySync.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Cb.Samples.ModulesEntitySync.Permissions;

public class ModulesEntitySyncPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ModulesEntitySyncPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ModulesEntitySyncPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ModulesEntitySyncResource>(name);
    }
}
