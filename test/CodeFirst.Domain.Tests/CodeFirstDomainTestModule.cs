using CodeFirst.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CodeFirst;

[DependsOn(
    typeof(CodeFirstEntityFrameworkCoreTestModule)
    )]
public class CodeFirstDomainTestModule : AbpModule
{

}
