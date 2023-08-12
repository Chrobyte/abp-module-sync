﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Cb.Samples.ProjectManagement.MongoDB;

[ConnectionStringName(ProjectManagementDbProperties.ConnectionStringName)]
public class ProjectManagementMongoDbContext : AbpMongoDbContext, IProjectManagementMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureProjectManagement();
    }
}
