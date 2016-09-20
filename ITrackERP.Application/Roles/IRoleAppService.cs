using System.Threading.Tasks;
using Abp.Application.Services;
using ITrackERP.Roles.Dto;

namespace ITrackERP.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
