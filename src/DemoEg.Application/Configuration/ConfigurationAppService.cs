using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DemoEg.Configuration.Dto;

namespace DemoEg.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DemoEgAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
