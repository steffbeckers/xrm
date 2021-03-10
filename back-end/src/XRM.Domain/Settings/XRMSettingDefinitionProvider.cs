using Volo.Abp.Settings;

namespace XRM.Settings
{
    public class XRMSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(XRMSettings.MySetting1));
        }
    }
}
