using Volo.Abp.Modularity;

namespace YoutubeStart;

[DependsOn(
    typeof(YoutubeStartDomainModule),
    typeof(YoutubeStartTestBaseModule)
)]
public class YoutubeStartDomainTestModule : AbpModule
{

}
