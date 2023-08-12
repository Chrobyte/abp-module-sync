using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Cb.Samples.CustomerManagement.Countries;

public class CountryAppService : CrudAppService<
    Country,
    CountryDto,
    Guid,
    PagedAndSortedResultRequestDto,
    CountryCreateUpdateDto>,
    ICountryAppService
{
    public CountryAppService(IRepository<Country, Guid> repository) : base(repository)
    {
    }
}
