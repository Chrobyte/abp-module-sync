using Cb.Samples.ProjectManagement.Samples;
using Xunit;

namespace Cb.Samples.ProjectManagement.MongoDB.Samples;

[Collection(MongoTestCollection.Name)]
public class SampleRepository_Tests : SampleRepository_Tests<ProjectManagementMongoDbTestModule>
{
    /* Don't write custom repository tests here, instead write to
     * the base class.
     * One exception can be some specific tests related to MongoDB.
     */
}
