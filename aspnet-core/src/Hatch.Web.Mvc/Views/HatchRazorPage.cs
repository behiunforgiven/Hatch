using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Hatch.Web.Views
{
    public abstract class HatchRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected HatchRazorPage()
        {
            LocalizationSourceName = HatchConsts.LocalizationSourceName;
        }
    }
}
