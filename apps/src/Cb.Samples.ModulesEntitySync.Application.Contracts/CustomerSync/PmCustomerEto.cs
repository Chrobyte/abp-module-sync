using System;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus;

namespace Cb.Samples.ModulesEntitySync.CustomerSync;

[EventName("PmCustomer")]
public class PmCustomerEto : EntityEto<Guid>
{
    public string Name { get; set; } = default!;
}

