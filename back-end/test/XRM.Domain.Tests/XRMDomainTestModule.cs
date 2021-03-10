using XRM.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace XRM
{
    [DependsOn(
        typeof(XRMEntityFrameworkCoreTestModule)
        )]
    public class XRMDomainTestModule : AbpModule
    {

    }
}