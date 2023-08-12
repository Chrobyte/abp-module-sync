using Cb.Samples.ProjectManagement.Customers;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Cb.Samples.ProjectManagement.Projects;

public interface IProjectAppService : ICrudAppService<
        ProjectDto,
        Guid,
        PagedAndSortedResultRequestDto,
        ProjectCreateUpdateDto>
{
    Task<ListResultDto<CustomerDto>> GetCustomerLookupAsync();
}