using CodeFirst.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CodeFirst.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CodeFirstEntityFrameworkCoreModule),
    typeof(CodeFirstApplicationContractsModule)
    )]
public class CodeFirstDbMigratorModule : AbpModule
{

}
