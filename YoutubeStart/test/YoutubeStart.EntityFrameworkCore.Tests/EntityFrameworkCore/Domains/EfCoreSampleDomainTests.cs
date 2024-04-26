using YoutubeStart.Samples;
using Xunit;

namespace YoutubeStart.EntityFrameworkCore.Domains;

[Collection(YoutubeStartTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<YoutubeStartEntityFrameworkCoreTestModule>
{

}
