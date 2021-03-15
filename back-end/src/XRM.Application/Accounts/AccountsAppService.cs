using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using XRM.Accounts.Dto;
using XRM.Permissions;

namespace XRM.Accounts
{
    public class AccountsAppService :
        CrudAppService<
            Account,
            AccountDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateAccountDto,
            UpdateAccountDto
        >,
        IAccountsAppService
    {
        public AccountsAppService(IRepository<Account, Guid> accountRepository) : base(accountRepository)
        {
            GetListPolicyName = XRMPermissions.Accounts;
            GetPolicyName = XRMPermissions.Accounts;
            CreatePolicyName = XRMPermissions.CreateAccounts;
            UpdatePolicyName = XRMPermissions.EditAccounts;
            DeletePolicyName = XRMPermissions.DeleteAccounts;
        }
    }
}
