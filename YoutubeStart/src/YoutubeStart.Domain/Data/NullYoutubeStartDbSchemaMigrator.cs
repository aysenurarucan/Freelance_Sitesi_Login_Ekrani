using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace YoutubeStart.Data;

/* This is used if database provider does't define
 * IYoutubeStartDbSchemaMigrator implementation.
 */
public class NullYoutubeStartDbSchemaMigrator : IYoutubeStartDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
