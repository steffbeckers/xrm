using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
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
        typeof(XRMApplicationContractsModule),
        typeof(AbpAccountHttpApiClientModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpPermissionManagementHttpApiClientModule),
        typeof(AbpTenantManagementHttpApiClientModule),
        typeof(AbpFeatureManagementHttpApiClientModule)
    )]
    [DependsOn(typeof(SalesHttpApiClientModule))]
    [DependsOn(typeof(ProductManagementHttpApiClientModule))]
    public class XRMHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(XRMApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
