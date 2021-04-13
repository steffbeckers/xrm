using XRM.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace XRM.Permissions
{
    public class XRMPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var xrmGroup = context.AddGroup(XRMPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(XRMPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<XRMResource>(name);
        }
    }
}
