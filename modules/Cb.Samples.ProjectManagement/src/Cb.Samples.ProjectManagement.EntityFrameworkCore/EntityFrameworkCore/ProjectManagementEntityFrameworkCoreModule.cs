using Cb.Samples.ProjectManagement.Customers;
using Cb.Samples.ProjectManagement.Projects;
using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
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
            options.AddRepository<Project, EfCoreRepository<IProjectManagementDbContext, Project, Guid>>();
            options.AddRepository<Customer, EfCoreRepository<IProjectManagementDbContext, Customer, Guid>>();
        });
    }
}
