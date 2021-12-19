using System.Collections.Generic;
using Hatch.Roles.Dto;

namespace Hatch.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
