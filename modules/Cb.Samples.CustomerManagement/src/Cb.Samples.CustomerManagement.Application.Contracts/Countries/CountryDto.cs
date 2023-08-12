using System;
using Volo.Abp.Application.Dtos;

namespace Cb.Samples.CustomerManagement.Countries;

public class CountryDto : EntityDto<Guid>
{
    public string Name { get; set; } = default!;
}
