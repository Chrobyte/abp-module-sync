using AutoMapper;
using Cb.Samples.CustomerManagement.Countries;
using Cb.Samples.CustomerManagement.Customers;

namespace Cb.Samples.CustomerManagement.Blazor;

public class CustomerManagementBlazorAutoMapperProfile : Profile
{
    public CustomerManagementBlazorAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<CustomerDto, CustomerCreateUpdateDto>();
        CreateMap<CountryDto, CountryCreateUpdateDto>();
    }
}
