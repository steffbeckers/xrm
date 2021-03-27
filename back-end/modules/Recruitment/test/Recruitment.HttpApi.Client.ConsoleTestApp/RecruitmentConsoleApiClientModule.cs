using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Recruitment
{
    [DependsOn(
        typeof(RecruitmentHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class RecruitmentConsoleApiClientModule : AbpModule
    {
        
    }
}
