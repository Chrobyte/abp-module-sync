using System;
using System.ComponentModel.DataAnnotations;

namespace Cb.Samples.CustomerManagement.Customers;

public class CustomerCreateUpdateDto
{
    [Required]
    public string Name { get; set; }

    public Guid? CountryId { get; set; }
}
