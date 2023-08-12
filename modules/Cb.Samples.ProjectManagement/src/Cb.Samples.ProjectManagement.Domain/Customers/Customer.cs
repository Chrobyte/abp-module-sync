using System;
using Volo.Abp.Domain.Entities;

namespace Cb.Samples.ProjectManagement.Customers;

public class Customer : Entity<Guid>
{
    public string Name { get; set; } = default!;
}
