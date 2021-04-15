using Volo.Abp.Reflection;

namespace ProductManagement.Permissions
{
    public class ProductManagementPermissions
    {
        public const string GroupName = "ProductManagement";

        // Accounts
        public const string Products = GroupName + ".Accounts";
        public const string CreateProducts = Products + ".Create";
        public const string EditProducts = Products + ".Update";
        public const string DeleteProducts = Products + ".Delete";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProductManagementPermissions));
        }
    }
}