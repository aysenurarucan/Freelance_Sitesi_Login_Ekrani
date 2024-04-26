using YoutubeStart.Samples;
using Xunit;

namespace YoutubeStart.EntityFrameworkCore.Applications;

[Collection(YoutubeStartTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<YoutubeStartEntityFrameworkCoreTestModule>
{

}
