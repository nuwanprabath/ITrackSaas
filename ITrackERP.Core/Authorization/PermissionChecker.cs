using Abp.Authorization;
using ITrackERP.Authorization.Roles;
using ITrackERP.MultiTenancy;
using ITrackERP.Users;

namespace ITrackERP.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
