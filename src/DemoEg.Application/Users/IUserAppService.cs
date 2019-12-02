using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DemoEg.Roles.Dto;
using DemoEg.Users.Dto;

namespace DemoEg.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
