using Cb.Samples.CustomerManagement.Countries;
using Cb.Samples.CustomerManagement.Customers;
using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Cb.Samples.CustomerManagement.EntityFrameworkCore;

[DependsOn(
    typeof(CustomerManagementDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class CustomerManagementEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<CustomerManagementDbContext>(options =>
        {
            options.AddRepository<Country, EfCoreRepository<ICustomerManagementDbContext, Country, Guid>>();
            options.AddRepository<Customer, EfCoreRepository<ICustomerManagementDbContext, Customer, Guid>>();
        });
    }
}
