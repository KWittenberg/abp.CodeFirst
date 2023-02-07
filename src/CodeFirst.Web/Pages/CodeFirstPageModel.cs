using CodeFirst.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CodeFirst.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CodeFirstPageModel : AbpPageModel
{
    protected CodeFirstPageModel()
    {
        LocalizationResourceType = typeof(CodeFirstResource);
    }
}
