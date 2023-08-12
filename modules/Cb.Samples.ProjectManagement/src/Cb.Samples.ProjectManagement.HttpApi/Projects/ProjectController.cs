using Cb.Samples.ProjectManagement.Customers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Cb.Samples.ProjectManagement.Projects;

[RemoteService(Name = ProjectManagementRemoteServiceConsts.RemoteServiceName)]
[Route("/api/project-management/project")]
public class ProjectController : ProjectManagementController, IProjectAppService
{
    private readonly IProjectAppService _service;

    public ProjectController(IProjectAppService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("customer-lookup")]
    public virtual Task<ListResultDto<CustomerDto>> GetCustomerLookupAsync()
    {
        return _service.GetCustomerLookupAsync();
    }

    [HttpPost]
    [Route("")]
    public virtual Task<ProjectDto> CreateAsync(ProjectCreateUpdateDto input)
    {
        return _service.CreateAsync(input);
    }

    [HttpPut]
    [Route("{id}")]
    public virtual Task<ProjectDto> UpdateAsync(Guid id, ProjectCreateUpdateDto input)
    {
        return _service.UpdateAsync(id, input);
    }

    [HttpDelete]
    [Route("{id}")]
    public virtual Task DeleteAsync(Guid id)
    {
        return _service.DeleteAsync(id);
    }

    [HttpGet]
    [Route("{id}")]
    public virtual Task<ProjectDto> GetAsync(Guid id)
    {
        return _service.GetAsync(id);
    }

    [HttpGet]
    [Route("")]
    public virtual Task<PagedResultDto<ProjectDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return _service.GetListAsync(input);
    }
}