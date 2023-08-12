using Cb.Samples.CustomerManagement.Countries;
using Cb.Samples.CustomerManagement.Customers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Cb.Samples.CustomerManagement.EntityFrameworkCore;

[ConnectionStringName(CustomerManagementDbProperties.ConnectionStringName)]
public class CustomerManagementDbContext : AbpDbContext<CustomerManagementDbContext>, ICustomerManagementDbContext
{
     public DbSet<Country> Countries { get; set; }
     public DbSet<Customer> Customers { get; set; }

    public CustomerManagementDbContext(DbContextOptions<CustomerManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureCustomerManagement();
    }
}
