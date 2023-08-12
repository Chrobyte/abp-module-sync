using System;
using Volo.Abp.Application.Dtos;

namespace Cb.Samples.ProjectManagement.Customers;

public class CustomerDto : EntityDto<Guid>
{
    public string Name { get; set; } = default!;
}
