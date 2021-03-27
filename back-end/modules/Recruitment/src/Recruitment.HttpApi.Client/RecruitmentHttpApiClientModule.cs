using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Recruitment
{
    [DependsOn(
        typeof(RecruitmentApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class RecruitmentHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Recruitment";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(RecruitmentApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
