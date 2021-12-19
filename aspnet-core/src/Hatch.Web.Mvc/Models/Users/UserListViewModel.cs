using System.Collections.Generic;
using Hatch.Roles.Dto;

namespace Hatch.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
