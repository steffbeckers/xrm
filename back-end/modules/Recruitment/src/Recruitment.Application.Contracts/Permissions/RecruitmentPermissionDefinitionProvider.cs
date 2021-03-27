using Recruitment.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Recruitment.Permissions
{
    public class RecruitmentPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(RecruitmentPermissions.GroupName, L("Permission:Recruitment"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<RecruitmentResource>(name);
        }
    }
}