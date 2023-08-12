using Cb.Samples.ProjectManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Cb.Samples.ProjectManagement.Permissions;

public class ProjectManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProjectManagementPermissions.GroupName, L("Permission:ProjectManagement"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProjectManagementResource>(name);
    }
}
