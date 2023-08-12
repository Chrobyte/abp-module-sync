using System.ComponentModel.DataAnnotations;

namespace Cb.Samples.ProjectManagement.Customers;

public class CustomerCreateUpdateDto
{
    [Required]
    public string Name { get; set; }
}
