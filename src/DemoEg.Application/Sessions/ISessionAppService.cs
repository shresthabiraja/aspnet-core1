using System.Threading.Tasks;
using Abp.Application.Services;
using DemoEg.Sessions.Dto;

namespace DemoEg.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
