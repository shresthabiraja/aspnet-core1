using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DemoEg.MultiTenancy.Dto;

namespace DemoEg.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

