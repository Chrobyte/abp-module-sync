using Cb.Samples.CustomerManagement.Countries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Cb.Samples.CustomerManagement.Customers;

// we ommit checking for country fk constraint on customer manipulation for simplicity of this demo

public class CustomerAppService : CrudAppService<
    Customer,
    CustomerDto,
    Guid,
    PagedAndSortedResultRequestDto,
    CustomerCreateUpdateDto>,
    ICustomerAppService
{
    private IReadOnlyRepository<Country, Guid> _countryRepository;

    public CustomerAppService(
        IRepository<Customer, Guid> repository,
        IReadOnlyRepository<Country, Guid> countryRepository) : base(repository)
    {
        _countryRepository = countryRepository;
    }

    protected override async Task<CustomerDto> MapToGetOutputDtoAsync(Customer entity)
    {
        var result = ObjectMapper.Map<Customer, CustomerDto>(entity);

        if (!entity.CountryId.HasValue)
        {
            return result;
        }

        var country = await _countryRepository.GetAsync(entity.CountryId.Value);

        result.CountryName = country.Name;

        return result;
    }

    public async Task<ListResultDto<CountryDto>> GetCountryLookupAsync()
    {
        var countries = (await _countryRepository.GetListAsync()) ?? new List<Country>();

        var mapped = ObjectMapper.Map<List<Country>, List<CountryDto>>(countries);

        return new ListResultDto<CountryDto>(items: mapped);
    }
}
