using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Hatch.Authorization;

namespace Hatch
{
    [DependsOn(
        typeof(HatchCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HatchApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HatchAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HatchApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
