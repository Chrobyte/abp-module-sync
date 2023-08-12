using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Cb.Samples.CustomerManagement.MongoDB;

public static class CustomerManagementMongoDbContextExtensions
{
    public static void ConfigureCustomerManagement(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
