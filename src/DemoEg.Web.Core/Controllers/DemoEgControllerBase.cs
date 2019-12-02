using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DemoEg.Controllers
{
    public abstract class DemoEgControllerBase: AbpController
    {
        protected DemoEgControllerBase()
        {
            LocalizationSourceName = DemoEgConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
