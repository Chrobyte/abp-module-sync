using System.ComponentModel.DataAnnotations;

namespace Cb.Samples.CustomerManagement.Countries;

public class CountryCreateUpdateDto
{
    [Required]
    public string Name { get; set; }
}
