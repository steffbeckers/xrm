using Volo.Abp.Reflection;

namespace Recruitment.Permissions
{
    public class RecruitmentPermissions
    {
        public const string GroupName = "Recruitment";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(RecruitmentPermissions));
        }
    }
}