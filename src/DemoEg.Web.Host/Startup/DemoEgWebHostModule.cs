using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DemoEg.Configuration;

namespace DemoEg.Web.Host.Startup
{
    [DependsOn(
       typeof(DemoEgWebCoreModule))]
    public class DemoEgWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DemoEgWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemoEgWebHostModule).GetAssembly());
        }
    }
}
