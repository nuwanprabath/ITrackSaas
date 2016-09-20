using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using ITrackERP.Authorization.Roles;
using ITrackERP.MultiTenancy;
using ITrackERP.Users;
using ITRACK.Company;
using ITRACK.Costing;
using ITRACK.Cutting;

namespace ITrackERP.EntityFramework
{
    public class ITrackERPDbContext : AbpZeroDbContext<Tenant, Role, User>
    {

        public virtual IDbSet<Style> Styles { get; set; }

        public virtual IDbSet<WorkOrder> WorkOrders { get; set; }

        public virtual IDbSet<WorkOrderRatio>WorkOrderRatios { get; set; }

        public virtual IDbSet<CuttingRatio> CuttingRatios { get; set; }

        public virtual IDbSet<CuttingRatioItem> CuttingRatioItems { get; set; }



        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ITrackERPDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ITrackERPDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ITrackERPDbContext since ABP automatically handles it.
         */
        public ITrackERPDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ITrackERPDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
