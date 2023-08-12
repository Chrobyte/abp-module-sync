using System;
using System.ComponentModel.DataAnnotations;

namespace Cb.Samples.ProjectManagement.Projects;

public class ProjectCreateUpdateDto
{
    [Required]
    public string Name { get; set; }

    [Required]
    public Guid CustomerId { get; set; }
}
