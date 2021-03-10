using System;
using System.Collections.Generic;
using System.Text;
using XRM.Localization;
using Volo.Abp.Application.Services;

namespace XRM
{
    /* Inherit your application services from this class.
     */
    public abstract class XRMAppService : ApplicationService
    {
        protected XRMAppService()
        {
            LocalizationResource = typeof(XRMResource);
        }
    }
}
