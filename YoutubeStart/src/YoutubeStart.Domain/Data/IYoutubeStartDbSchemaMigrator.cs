using System.Threading.Tasks;

namespace YoutubeStart.Data;

public interface IYoutubeStartDbSchemaMigrator
{
    Task MigrateAsync();
}
