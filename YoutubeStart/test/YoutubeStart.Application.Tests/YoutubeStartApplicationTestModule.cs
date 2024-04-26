using Volo.Abp.Modularity;

namespace YoutubeStart;

[DependsOn(
    typeof(YoutubeStartApplicationModule),
    typeof(YoutubeStartDomainTestModule)
)]
public class YoutubeStartApplicationTestModule : AbpModule
{

}
