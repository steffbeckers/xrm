using XRM.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace XRM.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(XRMEntityFrameworkCoreDbMigrationsModule),
        typeof(XRMApplicationContractsModule)
        )]
    public class XRMDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
