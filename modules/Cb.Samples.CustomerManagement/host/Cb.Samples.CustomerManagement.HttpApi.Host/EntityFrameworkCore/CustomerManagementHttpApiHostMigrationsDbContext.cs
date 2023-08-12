using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Cb.Samples.CustomerManagement.EntityFrameworkCore;

public class CustomerManagementHttpApiHostMigrationsDbContext : AbpDbContext<CustomerManagementHttpApiHostMigrationsDbContext>
{
    public CustomerManagementHttpApiHostMigrationsDbContext(DbContextOptions<CustomerManagementHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureCustomerManagement();
    }
}
