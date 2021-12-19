using System.Threading.Tasks;
using Hatch.Models.TokenAuth;
using Hatch.Web.Controllers;
using Shouldly;
using Xunit;

namespace Hatch.Web.Tests.Controllers
{
    public class HomeController_Tests: HatchWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}