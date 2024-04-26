using Volo.Abp.Settings;

namespace YoutubeStart.Settings;

public class YoutubeStartSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(YoutubeStartSettings.MySetting1));
    }
}
