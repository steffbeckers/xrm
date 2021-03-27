using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Recruitment
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(RecruitmentDomainSharedModule)
    )]
    public class RecruitmentDomainModule : AbpModule
    {

    }
}
