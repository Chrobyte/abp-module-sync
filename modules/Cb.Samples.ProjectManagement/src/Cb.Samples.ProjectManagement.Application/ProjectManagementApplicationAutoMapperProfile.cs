using AutoMapper;
using Cb.Samples.ProjectManagement.Customers;
using Cb.Samples.ProjectManagement.Projects;

namespace Cb.Samples.ProjectManagement;

public class ProjectManagementApplicationAutoMapperProfile : Profile
{
    public ProjectManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Customer, CustomerDto>();
        CreateMap<CustomerCreateUpdateDto, Customer>();

        CreateMap<Project, ProjectDto>();
        CreateMap<ProjectCreateUpdateDto, Project>();
    }
}
