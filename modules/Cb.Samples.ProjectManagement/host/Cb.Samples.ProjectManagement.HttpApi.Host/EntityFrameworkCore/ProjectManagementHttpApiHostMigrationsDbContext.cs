using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Cb.Samples.ProjectManagement.EntityFrameworkCore;

public class ProjectManagementHttpApiHostMigrationsDbContext : AbpDbContext<ProjectManagementHttpApiHostMigrationsDbContext>
{
    public ProjectManagementHttpApiHostMigrationsDbContext(DbContextOptions<ProjectManagementHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureProjectManagement();
    }
}
