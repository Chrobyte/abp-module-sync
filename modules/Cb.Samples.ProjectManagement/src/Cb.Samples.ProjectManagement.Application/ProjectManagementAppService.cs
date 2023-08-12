using Cb.Samples.ProjectManagement.Localization;
using Volo.Abp.Application.Services;

namespace Cb.Samples.ProjectManagement;

public abstract class ProjectManagementAppService : ApplicationService
{
    protected ProjectManagementAppService()
    {
        LocalizationResource = typeof(ProjectManagementResource);
        ObjectMapperContext = typeof(ProjectManagementApplicationModule);
    }
}
