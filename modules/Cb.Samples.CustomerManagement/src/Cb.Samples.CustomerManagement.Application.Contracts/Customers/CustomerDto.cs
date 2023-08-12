using System;
using Volo.Abp.Application.Dtos;

namespace Cb.Samples.CustomerManagement.Customers;

public class CustomerDto : EntityDto<Guid>
{
    public string Name { get; set; } = default!;

    public string CountryName { get; set; } = default!;
}
