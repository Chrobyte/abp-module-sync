using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Cb.Samples.CustomerManagement.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
