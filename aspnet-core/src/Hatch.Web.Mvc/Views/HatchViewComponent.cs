using Abp.AspNetCore.Mvc.ViewComponents;

namespace Hatch.Web.Views
{
    public abstract class HatchViewComponent : AbpViewComponent
    {
        protected HatchViewComponent()
        {
            LocalizationSourceName = HatchConsts.LocalizationSourceName;
        }
    }
}
