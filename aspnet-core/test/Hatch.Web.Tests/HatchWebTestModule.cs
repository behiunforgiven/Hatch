using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Hatch.EntityFrameworkCore;
using Hatch.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Hatch.Web.Tests
{
    [DependsOn(
        typeof(HatchWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class HatchWebTestModule : AbpModule
    {
        public HatchWebTestModule(HatchEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HatchWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HatchWebMvcModule).Assembly);
        }
    }
}