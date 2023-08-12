using Cb.Samples.CustomerManagement.Countries;
using Cb.Samples.CustomerManagement.Customers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Cb.Samples.CustomerManagement.EntityFrameworkCore;

[ConnectionStringName(CustomerManagementDbProperties.ConnectionStringName)]
public interface ICustomerManagementDbContext : IEfCoreDbContext
{
     DbSet<Country> Countries { get; }
     DbSet<Customer> Customers { get; }
}
