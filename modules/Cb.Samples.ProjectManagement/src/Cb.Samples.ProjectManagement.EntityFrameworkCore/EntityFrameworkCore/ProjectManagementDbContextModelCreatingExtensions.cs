using Cb.Samples.ProjectManagement.Customers;
using Cb.Samples.ProjectManagement.Projects;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Cb.Samples.ProjectManagement.EntityFrameworkCore;

public static class ProjectManagementDbContextModelCreatingExtensions
{
    public static void ConfigureProjectManagement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Customer>(b =>
        {
            //Configure table & schema name
            b.ToTable(ProjectManagementDbProperties.DbTablePrefix + "Customers", ProjectManagementDbProperties.DbSchema);

            b.ConfigureByConvention();
        });

        builder.Entity<Project>(b =>
        {
            //Configure table & schema name
            b.ToTable(ProjectManagementDbProperties.DbTablePrefix + "Projects", ProjectManagementDbProperties.DbSchema);

            b.ConfigureByConvention();

            b.HasOne<Customer>()
                .WithMany()
                .HasForeignKey(p => p.CustomerId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
