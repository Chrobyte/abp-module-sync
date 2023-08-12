using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Cb.Samples.ModulesEntitySync.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ModulesEntitySyncDbContextFactory : IDesignTimeDbContextFactory<ModulesEntitySyncDbContext>
{
    public ModulesEntitySyncDbContext CreateDbContext(string[] args)
    {
        ModulesEntitySyncEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ModulesEntitySyncDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ModulesEntitySyncDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Cb.Samples.ModulesEntitySync.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
