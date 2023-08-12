using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Cb.Samples.CustomerManagement.Countries;

public interface ICountryAppService : ICrudAppService<
        CountryDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CountryCreateUpdateDto>
{
}
