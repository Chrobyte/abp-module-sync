using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Cb.Samples.ProjectManagement.Customers;

public class CustomerAppService : CrudAppService<
    Customer,
    CustomerDto,
    Guid,
    PagedAndSortedResultRequestDto,
    CustomerCreateUpdateDto>,
    ICustomerAppService
{
    public CustomerAppService(
        IRepository<Customer, Guid> repository) : base(repository)
    {
    }
}
