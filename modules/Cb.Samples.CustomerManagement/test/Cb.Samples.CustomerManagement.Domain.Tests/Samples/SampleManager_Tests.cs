using System.Threading.Tasks;
using Xunit;

namespace Cb.Samples.CustomerManagement.Samples;

public class SampleManager_Tests : CustomerManagementDomainTestBase
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
