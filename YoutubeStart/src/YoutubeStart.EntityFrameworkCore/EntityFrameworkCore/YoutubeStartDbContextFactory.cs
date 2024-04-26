using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace YoutubeStart.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class YoutubeStartDbContextFactory : IDesignTimeDbContextFactory<YoutubeStartDbContext>
{
    public YoutubeStartDbContext CreateDbContext(string[] args)
    {
        YoutubeStartEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<YoutubeStartDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new YoutubeStartDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../YoutubeStart.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
