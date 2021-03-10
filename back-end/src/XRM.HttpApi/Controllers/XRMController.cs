using XRM.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XRM.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class XRMController : AbpController
    {
        protected XRMController()
        {
            LocalizationResource = typeof(XRMResource);
        }
    }
}