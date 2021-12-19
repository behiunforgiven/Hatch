using System.Threading.Tasks;
using Abp.Application.Services;
using Hatch.Sessions.Dto;

namespace Hatch.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
