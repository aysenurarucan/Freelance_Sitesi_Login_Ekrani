using YoutubeStart.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace YoutubeStart.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class YoutubeStartController : AbpControllerBase
{
    protected YoutubeStartController()
    {
        LocalizationResource = typeof(YoutubeStartResource);
    }
}
