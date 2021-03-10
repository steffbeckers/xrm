using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using XRM.Data;
using Volo.Abp.DependencyInjection;

namespace XRM.EntityFrameworkCore
{
    public class EntityFrameworkCoreXRMDbSchemaMigrator
        : IXRMDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreXRMDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the XRMMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<XRMMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}