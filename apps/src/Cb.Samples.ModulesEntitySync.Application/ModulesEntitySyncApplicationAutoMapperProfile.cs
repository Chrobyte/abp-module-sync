using AutoMapper;
using Cb.Samples.ModulesEntitySync.CustomerSync;

namespace Cb.Samples.ModulesEntitySync;

public class ModulesEntitySyncApplicationAutoMapperProfile : Profile
{
    public ModulesEntitySyncApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<CustomerManagement.Customers.Customer, CmCustomerEto>();
        CreateMap<CmCustomerEto, ProjectManagement.Customers.Customer>();

        CreateMap<ProjectManagement.Customers.Customer, PmCustomerEto>();
        CreateMap<PmCustomerEto, CustomerManagement.Customers.Customer>();
    }
}
