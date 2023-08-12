using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Cb.Samples.ProjectManagement.Customers;

public interface ICustomerAppService : ICrudAppService<
        CustomerDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CustomerCreateUpdateDto>
{
}