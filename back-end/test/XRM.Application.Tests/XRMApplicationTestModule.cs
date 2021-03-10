using Volo.Abp.Modularity;

namespace XRM
{
    [DependsOn(
        typeof(XRMApplicationModule),
        typeof(XRMDomainTestModule)
        )]
    public class XRMApplicationTestModule : AbpModule
    {

    }
}