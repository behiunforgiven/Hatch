using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Hatch.Controllers
{
    public abstract class HatchControllerBase: AbpController
    {
        protected HatchControllerBase()
        {
            LocalizationSourceName = HatchConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
