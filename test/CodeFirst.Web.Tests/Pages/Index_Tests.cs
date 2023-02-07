using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CodeFirst.Pages;

public class Index_Tests : CodeFirstWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
