using System;
using Volo.Abp.Application.Dtos;

namespace Cb.Samples.ProjectManagement.Projects;

public class ProjectDto : EntityDto<Guid>
{
    public string Name { get; set; }

    public string CustomerName { get; set; }
}
