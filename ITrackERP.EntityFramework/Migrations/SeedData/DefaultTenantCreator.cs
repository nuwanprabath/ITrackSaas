using System.Linq;
using ITrackERP.EntityFramework;
using ITrackERP.MultiTenancy;

namespace ITrackERP.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ITrackERPDbContext _context;

        public DefaultTenantCreator(ITrackERPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
