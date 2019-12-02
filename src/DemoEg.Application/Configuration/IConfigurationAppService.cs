using System.Threading.Tasks;
using DemoEg.Configuration.Dto;

namespace DemoEg.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
