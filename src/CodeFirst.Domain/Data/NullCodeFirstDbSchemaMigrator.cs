using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CodeFirst.Data;

/* This is used if database provider does't define
 * ICodeFirstDbSchemaMigrator implementation.
 */
public class NullCodeFirstDbSchemaMigrator : ICodeFirstDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
