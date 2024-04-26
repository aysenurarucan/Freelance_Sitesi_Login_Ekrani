using System;
using System.Collections.Generic;
using System.Text;
using YoutubeStart.Localization;
using Volo.Abp.Application.Services;

namespace YoutubeStart;

/* Inherit your application services from this class.
 */
public abstract class YoutubeStartAppService : ApplicationService
{
    protected YoutubeStartAppService()
    {
        LocalizationResource = typeof(YoutubeStartResource);
    }
}
