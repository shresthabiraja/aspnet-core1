using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DemoEg.Authorization;

namespace DemoEg
{
    [DependsOn(
        typeof(DemoEgCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DemoEgApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DemoEgAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DemoEgApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
