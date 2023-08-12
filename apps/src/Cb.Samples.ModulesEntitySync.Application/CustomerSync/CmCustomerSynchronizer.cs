using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Cb.Samples.ModulesEntitySync.CustomerSync;

/// <summary>
/// Used when a "Customer Management Customer" is manipulated to Update "Project Management Customer"
/// </summary>
public class CmCustomerSynchronizer : EntitySynchronizer<ProjectManagement.Customers.Customer, Guid, CmCustomerEto>
{
    public CmCustomerSynchronizer(
        IObjectMapper objectMapper,
        IRepository<ProjectManagement.Customers.Customer, Guid> repository) : base(objectMapper, repository)
    {
    }

    /// <summary>
    /// Normally you would do something more meaningful here to map both entities!
    /// <para/>
    /// We simply map by name - which is somewhat retarded because the name is not even a constraint in our modules.
    /// </summary>
    /// <param name="eto"></param>
    /// <returns></returns>
    protected override Task<ProjectManagement.Customers.Customer> FindLocalEntityAsync(CmCustomerEto eto)
    {
        return Repository.FindAsync(x => x.Name == eto.Name);
    }

    protected override Task<bool> IsEtoNewerAsync(CmCustomerEto eto, ProjectManagement.Customers.Customer localEntity)
    {
        return Task.FromResult(localEntity == null || eto.Name != localEntity.Name);
    }
}