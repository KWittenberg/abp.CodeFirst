using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CodeFirst.Web;

[Dependency(ReplaceServices = true)]
public class CodeFirstBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CodeFirst";
}
