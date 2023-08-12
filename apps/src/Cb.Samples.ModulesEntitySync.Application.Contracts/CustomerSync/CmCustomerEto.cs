using System;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus;

namespace Cb.Samples.ModulesEntitySync.CustomerSync;

[EventName("CmCustomer")]
public class CmCustomerEto : EntityEto<Guid>
{
    public string Name { get; set; } = default!;
}
