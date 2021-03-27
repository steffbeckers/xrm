using Recruitment.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Recruitment
{
    public abstract class RecruitmentController : AbpController
    {
        protected RecruitmentController()
        {
            LocalizationResource = typeof(RecruitmentResource);
        }
    }
}
