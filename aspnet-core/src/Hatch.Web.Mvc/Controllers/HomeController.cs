using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Hatch.Controllers;

namespace Hatch.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : HatchControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
