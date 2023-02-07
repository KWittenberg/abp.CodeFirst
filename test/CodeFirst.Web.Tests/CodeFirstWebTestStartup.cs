using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace CodeFirst;

public class CodeFirstWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<CodeFirstWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
