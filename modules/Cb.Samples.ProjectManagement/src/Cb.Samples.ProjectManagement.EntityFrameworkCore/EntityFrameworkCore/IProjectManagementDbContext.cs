using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Cb.Samples.ProjectManagement.EntityFrameworkCore;

[ConnectionStringName(ProjectManagementDbProperties.ConnectionStringName)]
public interface IProjectManagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
