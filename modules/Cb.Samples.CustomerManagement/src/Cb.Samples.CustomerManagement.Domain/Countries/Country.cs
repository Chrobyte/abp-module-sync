using System;
using Volo.Abp.Domain.Entities;

namespace Cb.Samples.CustomerManagement.Countries;

public class Country : Entity<Guid>
{
    public string Name { get; set; } = default!;
}
