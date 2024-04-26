using YoutubeStart.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace YoutubeStart.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(YoutubeStartEntityFrameworkCoreModule),
    typeof(YoutubeStartApplicationContractsModule)
    )]
public class YoutubeStartDbMigratorModule : AbpModule
{
}
