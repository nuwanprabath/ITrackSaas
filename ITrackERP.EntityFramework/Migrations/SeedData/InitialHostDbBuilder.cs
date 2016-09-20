using ITrackERP.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ITrackERP.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ITrackERPDbContext _context;

        public InitialHostDbBuilder(ITrackERPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
