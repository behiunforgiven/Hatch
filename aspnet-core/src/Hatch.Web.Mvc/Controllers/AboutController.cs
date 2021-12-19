using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Hatch.Controllers;

namespace Hatch.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : HatchControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
