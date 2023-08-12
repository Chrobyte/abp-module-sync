using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Cb.Samples.CustomerManagement.EntityFrameworkCore;

public class CustomerManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<CustomerManagementHttpApiHostMigrationsDbContext>
{
    public CustomerManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<CustomerManagementHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("CustomerManagement"));

        return new CustomerManagementHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
