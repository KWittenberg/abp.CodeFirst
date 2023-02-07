using System;
using System.Collections.Generic;
using System.Text;
using CodeFirst.Localization;
using Volo.Abp.Application.Services;

namespace CodeFirst;

/* Inherit your application services from this class.
 */
public abstract class CodeFirstAppService : ApplicationService
{
    protected CodeFirstAppService()
    {
        LocalizationResource = typeof(CodeFirstResource);
    }
}
