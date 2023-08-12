using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Cb.Samples.CustomerManagement;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class CustomerManagementInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CustomerManagementInstallerModule>();
        });
    }
}
