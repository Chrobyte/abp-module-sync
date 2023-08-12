using AutoMapper;
using Cb.Samples.CustomerManagement.Countries;
using Cb.Samples.CustomerManagement.Customers;

namespace Cb.Samples.CustomerManagement;

public class CustomerManagementApplicationAutoMapperProfile : Profile
{
    public CustomerManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Country, CountryDto>();
        CreateMap<CountryCreateUpdateDto, Country>();

        CreateMap<Customer, CustomerDto>();
        CreateMap<CustomerCreateUpdateDto, Customer>();
    }
}
