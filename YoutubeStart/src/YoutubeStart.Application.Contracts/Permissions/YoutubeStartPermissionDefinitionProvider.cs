using YoutubeStart.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace YoutubeStart.Permissions;

public class YoutubeStartPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(YoutubeStartPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(YoutubeStartPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<YoutubeStartResource>(name);
    }
}
