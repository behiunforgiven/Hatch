using System.Collections.Generic;
using Hatch.Roles.Dto;

namespace Hatch.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}