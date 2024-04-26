using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace YoutubeStart.Blazor;

[Dependency(ReplaceServices = true)]
public class YoutubeStartBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "YoutubeStart";
}
