using System;
using Volo.Abp.Domain.Entities;

namespace Cb.Samples.ProjectManagement.Projects;

public class Project : Entity<Guid>
{
    public Guid CustomerId { get; set; }

    public string Name { get; set; } = default!;
}
