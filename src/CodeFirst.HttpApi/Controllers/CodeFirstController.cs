using CodeFirst.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CodeFirst.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CodeFirstController : AbpControllerBase
{
    protected CodeFirstController()
    {
        LocalizationResource = typeof(CodeFirstResource);
    }
}
