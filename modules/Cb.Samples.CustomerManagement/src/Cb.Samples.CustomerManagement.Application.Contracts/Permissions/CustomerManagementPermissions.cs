using Volo.Abp.Reflection;

namespace Cb.Samples.CustomerManagement.Permissions;

public class CustomerManagementPermissions
{
    public const string GroupName = "CustomerManagement";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CustomerManagementPermissions));
    }
}
