using System.Threading.Tasks;
using Abp.Application.Services;
using DemoEg.Authorization.Accounts.Dto;

namespace DemoEg.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
