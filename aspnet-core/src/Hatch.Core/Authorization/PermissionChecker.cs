using Abp.Authorization;
using Hatch.Authorization.Roles;
using Hatch.Authorization.Users;

namespace Hatch.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
