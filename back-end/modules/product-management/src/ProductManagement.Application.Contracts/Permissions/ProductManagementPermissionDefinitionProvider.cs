using ProductManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace ProductManagement.Permissions
{
    public class ProductManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var productManagementGroup = context.AddGroup(ProductManagementPermissions.GroupName, L("Permission:ProductManagement"));

            // Products
            PermissionDefinition productsPermission = productManagementGroup.AddPermission(ProductManagementPermissions.Products, L("Permission:Accounts"), MultiTenancySides.Both);
            productsPermission.AddChild(ProductManagementPermissions.CreateProducts, L("Permission:Accounts:Create"), MultiTenancySides.Both);
            productsPermission.AddChild(ProductManagementPermissions.EditProducts, L("Permission:Accounts:Edit"), MultiTenancySides.Both);
            productsPermission.AddChild(ProductManagementPermissions.DeleteProducts, L("Permission:Accounts:Delete"), MultiTenancySides.Both);
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ProductManagementResource>(name);
        }
    }
}