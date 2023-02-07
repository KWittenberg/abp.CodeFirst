using System.Threading.Tasks;

namespace CodeFirst.Data;

public interface ICodeFirstDbSchemaMigrator
{
    Task MigrateAsync();
}
