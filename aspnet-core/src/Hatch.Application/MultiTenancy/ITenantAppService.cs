using Abp.Application.Services;
using Hatch.MultiTenancy.Dto;

namespace Hatch.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

