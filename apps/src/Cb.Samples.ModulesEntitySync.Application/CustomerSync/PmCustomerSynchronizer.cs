using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Cb.Samples.ModulesEntitySync.CustomerSync;

/// <summary>
/// Used when a "Project Management Customer" is manipulated to Update "Customer Management Customer"
/// </summary>
public class PmCustomerSynchronizer : EntitySynchronizer<CustomerManagement.Customers.Customer, Guid, PmCustomerEto>
{
    public PmCustomerSynchronizer(
        IObjectMapper objectMapper,
        IRepository<CustomerManagement.Customers.Customer, Guid> repository
        ) : base(objectMapper, repository)
    {
    }

    /// <summary>
    /// Normally you would do something more meaningful here to map both entities!
    /// <para/>
    /// We simply map by name - which is somewhat retarded because the name is not even a constraint in our modules.
    /// </summary>
    /// <param name="eto"></param>
    /// <returns></returns>
    protected override Task<CustomerManagement.Customers.Customer> FindLocalEntityAsync(PmCustomerEto eto)
    {
        return Repository.FindAsync(x => x.Name == eto.Name);
    }

    protected override Task<bool> IsEtoNewerAsync(PmCustomerEto eto, CustomerManagement.Customers.Customer localEntity)
    {
        return Task.FromResult(localEntity == null || eto.Name != localEntity.Name);
    }
}