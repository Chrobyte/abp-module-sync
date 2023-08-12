using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Cb.Samples.ProjectManagement.EntityFrameworkCore;

public class ProjectManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ProjectManagementHttpApiHostMigrationsDbContext>
{
    public ProjectManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ProjectManagementHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("ProjectManagement"));

        return new ProjectManagementHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
