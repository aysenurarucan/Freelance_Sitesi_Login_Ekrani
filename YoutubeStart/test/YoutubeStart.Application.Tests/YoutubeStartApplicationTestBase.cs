using Volo.Abp.Modularity;

namespace YoutubeStart;

public abstract class YoutubeStartApplicationTestBase<TStartupModule> : YoutubeStartTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
