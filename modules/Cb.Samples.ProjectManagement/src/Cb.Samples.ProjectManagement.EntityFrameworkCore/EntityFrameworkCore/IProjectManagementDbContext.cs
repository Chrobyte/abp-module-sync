using Cb.Samples.ProjectManagement.Customers;
using Cb.Samples.ProjectManagement.Projects;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Cb.Samples.ProjectManagement.EntityFrameworkCore;

[ConnectionStringName(ProjectManagementDbProperties.ConnectionStringName)]
public interface IProjectManagementDbContext : IEfCoreDbContext
{
    DbSet<Customer> Customers { get; }
    DbSet<Project> Projects { get; }
}
