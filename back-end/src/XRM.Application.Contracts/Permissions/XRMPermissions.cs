namespace XRM.Permissions
{
    public static class XRMPermissions
    {
        public const string GroupName = "XRM";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        // Accounts
        public const string Accounts = GroupName + ".Accounts";
        public const string CreateAccounts = Accounts + ".Create";
        public const string EditAccounts = Accounts + ".Update";
        public const string DeleteAccounts = Accounts + ".Delete";
    }
}