using Cb.Samples.CustomerManagement.Countries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Cb.Samples.CustomerManagement.Customers;

[RemoteService(Name = CustomerManagementRemoteServiceConsts.RemoteServiceName)]
[Route("/api/customer-management/customer")]
public class CustomerController : CustomerManagementController, ICustomerAppService
{
    private readonly ICustomerAppService _service;

    public CustomerController(ICustomerAppService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("country-lookup")]
    public virtual Task<ListResultDto<CountryDto>> GetCountryLookupAsync()
    {
        return _service.GetCountryLookupAsync();
    }

    [HttpPost]
    [Route("")]
    public virtual Task<CustomerDto> CreateAsync(CustomerCreateUpdateDto input)
    {
        return _service.CreateAsync(input);
    }

    [HttpPut]
    [Route("{id}")]
    public virtual Task<CustomerDto> UpdateAsync(Guid id, CustomerCreateUpdateDto input)
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
    public virtual Task<CustomerDto> GetAsync(Guid id)
    {
        return _service.GetAsync(id);
    }

    [HttpGet]
    [Route("")]
    public virtual Task<PagedResultDto<CustomerDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return _service.GetListAsync(input);
    }
}