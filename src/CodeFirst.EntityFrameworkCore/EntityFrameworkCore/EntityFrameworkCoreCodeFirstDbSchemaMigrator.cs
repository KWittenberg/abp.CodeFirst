using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodeFirst.Data;
using Volo.Abp.DependencyInjection;

namespace CodeFirst.EntityFrameworkCore;

public class EntityFrameworkCoreCodeFirstDbSchemaMigrator
    : ICodeFirstDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCodeFirstDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CodeFirstDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CodeFirstDbContext>()
            .Database
            .MigrateAsync();
    }
}
