using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace XRM
{
    [Dependency(ReplaceServices = true)]
    public class XRMBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "XRM";
    }
}
