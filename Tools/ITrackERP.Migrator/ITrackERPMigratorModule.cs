using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ITrackERP.EntityFramework;

namespace ITrackERP.Migrator
{
    [DependsOn(typeof(ITrackERPDataModule))]
    public class ITrackERPMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ITrackERPDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}