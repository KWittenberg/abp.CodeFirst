using Volo.Abp.Modularity;

namespace CodeFirst;

[DependsOn(
    typeof(CodeFirstApplicationModule),
    typeof(CodeFirstDomainTestModule)
    )]
public class CodeFirstApplicationTestModule : AbpModule
{

}
