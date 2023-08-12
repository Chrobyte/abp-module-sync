using Cb.Samples.CustomerManagement.Countries;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Cb.Samples.CustomerManagement.Customers;

public interface ICustomerAppService : ICrudAppService<
        CustomerDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CustomerCreateUpdateDto>
{
    Task<ListResultDto<CountryDto>> GetCountryLookupAsync();
}
