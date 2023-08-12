using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Cb.Samples.ProjectManagement.MongoDB;

public static class ProjectManagementMongoDbContextExtensions
{
    public static void ConfigureProjectManagement(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
