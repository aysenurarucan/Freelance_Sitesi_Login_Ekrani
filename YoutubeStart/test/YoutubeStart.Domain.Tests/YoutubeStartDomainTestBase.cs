using Volo.Abp.Modularity;

namespace YoutubeStart;

/* Inherit from this class for your domain layer tests. */
public abstract class YoutubeStartDomainTestBase<TStartupModule> : YoutubeStartTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
