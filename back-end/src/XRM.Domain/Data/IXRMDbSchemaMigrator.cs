using System.Threading.Tasks;

namespace XRM.Data
{
    public interface IXRMDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
