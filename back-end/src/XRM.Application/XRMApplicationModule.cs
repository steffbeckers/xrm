using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using SteffBeckers.Abp.Sales;
using ProductManagement;

namespace XRM
{
    [DependsOn(
        typeof(XRMDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(XRMApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule)
        )]
    [DependsOn(typeof(SalesApplicationModule))]
    [DependsOn(typeof(ProductManagementApplicationModule))]
    public class XRMApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<XRMApplicationModule>();
            });
        }
    }
}
