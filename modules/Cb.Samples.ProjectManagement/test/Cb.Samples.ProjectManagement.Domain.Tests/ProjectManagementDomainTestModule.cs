using Cb.Samples.ProjectManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Cb.Samples.ProjectManagement;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ProjectManagementEntityFrameworkCoreTestModule)
    )]
public class ProjectManagementDomainTestModule : AbpModule
{

}
