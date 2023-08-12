using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Cb.Samples.ProjectManagement.EntityFrameworkCore;

[DependsOn(
    typeof(ProjectManagementDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class ProjectManagementEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ProjectManagementDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
