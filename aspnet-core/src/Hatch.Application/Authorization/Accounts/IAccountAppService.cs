using System.Threading.Tasks;
using Abp.Application.Services;
using Hatch.Authorization.Accounts.Dto;

namespace Hatch.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
