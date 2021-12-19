using System.Threading.Tasks;
using Hatch.Configuration.Dto;

namespace Hatch.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
