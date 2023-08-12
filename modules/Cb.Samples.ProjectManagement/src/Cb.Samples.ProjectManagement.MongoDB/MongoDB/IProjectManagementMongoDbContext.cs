using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Cb.Samples.ProjectManagement.MongoDB;

[ConnectionStringName(ProjectManagementDbProperties.ConnectionStringName)]
public interface IProjectManagementMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
