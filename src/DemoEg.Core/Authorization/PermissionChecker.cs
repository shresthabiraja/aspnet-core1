using Abp.Authorization;
using DemoEg.Authorization.Roles;
using DemoEg.Authorization.Users;

namespace DemoEg.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
