using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace XRM.Data
{
    /* This is used if database provider does't define
     * IXRMDbSchemaMigrator implementation.
     */
    public class NullXRMDbSchemaMigrator : IXRMDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}