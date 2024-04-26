using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YoutubeStart.Data;
using Volo.Abp.DependencyInjection;

namespace YoutubeStart.EntityFrameworkCore;

public class EntityFrameworkCoreYoutubeStartDbSchemaMigrator
    : IYoutubeStartDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreYoutubeStartDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the YoutubeStartDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<YoutubeStartDbContext>()
            .Database
            .MigrateAsync();
    }
}
