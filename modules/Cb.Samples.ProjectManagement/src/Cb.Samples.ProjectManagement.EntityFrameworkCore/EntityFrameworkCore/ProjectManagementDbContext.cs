using Cb.Samples.ProjectManagement.Customers;
using Cb.Samples.ProjectManagement.Projects;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Cb.Samples.ProjectManagement.EntityFrameworkCore;

[ConnectionStringName(ProjectManagementDbProperties.ConnectionStringName)]
public class ProjectManagementDbContext : AbpDbContext<ProjectManagementDbContext>, IProjectManagementDbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Project> Projects { get; set; }

    public ProjectManagementDbContext(DbContextOptions<ProjectManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureProjectManagement();
    }
}
