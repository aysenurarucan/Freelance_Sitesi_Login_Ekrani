using YoutubeStart.Localization;
using Volo.Abp.AspNetCore.Components;

namespace YoutubeStart.Blazor;

public abstract class YoutubeStartComponentBase : AbpComponentBase
{
    protected YoutubeStartComponentBase()
    {
        LocalizationResource = typeof(YoutubeStartResource);
    }
}
