using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace XRM.EntityFrameworkCore
{
    [DependsOn(
        typeof(XRMEntityFrameworkCoreModule)
        )]
    public class XRMEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<XRMMigrationsDbContext>();
        }
    }
}
