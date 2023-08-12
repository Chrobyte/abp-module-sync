using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Cb.Samples.ProjectManagement.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
