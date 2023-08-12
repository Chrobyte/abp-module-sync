using Cb.Samples.ProjectManagement.Customers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Cb.Samples.ProjectManagement.Projects;

public class ProjectAppService : CrudAppService<
    Project,
    ProjectDto,
    Guid,
    PagedAndSortedResultRequestDto,
    ProjectCreateUpdateDto>,
    IProjectAppService
{
    private IReadOnlyRepository<Customer, Guid> _customerRepository;

    public ProjectAppService(
        IRepository<Project, Guid> repository,
        IReadOnlyRepository<Customer, Guid> customerRepository)
        : base(repository)
    {
        _customerRepository = customerRepository;
    }

    protected override async Task<ProjectDto> MapToGetOutputDtoAsync(Project entity)
    {
        var result = ObjectMapper.Map<Project, ProjectDto>(entity);

        var customer = await _customerRepository.GetAsync(entity.CustomerId);

        result.CustomerName = customer.Name;

        return result;
    }

    public async Task<ListResultDto<CustomerDto>> GetCustomerLookupAsync()
    {
        var customers = (await _customerRepository.GetListAsync()) ?? new List<Customer>();

        var mapped = ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customers);

        return new ListResultDto<CustomerDto>(items: mapped);
    }
}
