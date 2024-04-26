using Xunit;

namespace YoutubeStart.EntityFrameworkCore;

[CollectionDefinition(YoutubeStartTestConsts.CollectionDefinitionName)]
public class YoutubeStartEntityFrameworkCoreCollection : ICollectionFixture<YoutubeStartEntityFrameworkCoreFixture>
{

}
