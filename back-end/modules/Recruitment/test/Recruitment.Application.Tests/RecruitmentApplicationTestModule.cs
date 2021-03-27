using Volo.Abp.Modularity;

namespace Recruitment
{
    [DependsOn(
        typeof(RecruitmentApplicationModule),
        typeof(RecruitmentDomainTestModule)
        )]
    public class RecruitmentApplicationTestModule : AbpModule
    {

    }
}
