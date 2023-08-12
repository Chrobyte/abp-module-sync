using System.Threading.Tasks;

namespace Cb.Samples.ModulesEntitySync.Data;

public interface IModulesEntitySyncDbSchemaMigrator
{
    Task MigrateAsync();
}
