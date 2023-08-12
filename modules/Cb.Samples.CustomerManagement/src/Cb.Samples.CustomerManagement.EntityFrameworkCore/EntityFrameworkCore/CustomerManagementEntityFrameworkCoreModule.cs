using Microsoft.Extensions.DependencyInjection;
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
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
