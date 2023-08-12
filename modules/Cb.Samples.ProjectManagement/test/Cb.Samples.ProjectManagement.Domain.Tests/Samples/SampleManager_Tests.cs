using System.Threading.Tasks;
using Xunit;

namespace Cb.Samples.ProjectManagement.Samples;

public class SampleManager_Tests : ProjectManagementDomainTestBase
{
    //private readonly SampleManager _sampleManager;

    public SampleManager_Tests()
    {
        //_sampleManager = GetRequiredService<SampleManager>();
    }

    [Fact]
    public Task Method1Async()
    {
        return Task.CompletedTask;
    }
}
