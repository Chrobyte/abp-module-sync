using AutoMapper;
using Cb.Samples.ProjectManagement.Customers;
using Cb.Samples.ProjectManagement.Projects;

namespace Cb.Samples.ProjectManagement.Blazor;

public class ProjectManagementBlazorAutoMapperProfile : Profile
{
    public ProjectManagementBlazorAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<CustomerDto, CustomerCreateUpdateDto>();
        CreateMap<ProjectDto, ProjectCreateUpdateDto>();
    }
}
