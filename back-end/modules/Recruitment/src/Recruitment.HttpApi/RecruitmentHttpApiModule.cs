using Localization.Resources.AbpUi;
using Recruitment.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Recruitment
{
    [DependsOn(
        typeof(RecruitmentApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class RecruitmentHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(RecruitmentHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<RecruitmentResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
