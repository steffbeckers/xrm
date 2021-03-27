using Recruitment.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Recruitment
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(RecruitmentEntityFrameworkCoreTestModule)
        )]
    public class RecruitmentDomainTestModule : AbpModule
    {
        
    }
}
