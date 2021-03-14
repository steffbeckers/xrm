using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using XRM.Accounts.Dto;
using XRM.Permissions;

namespace XRM.Accounts
{
    [Authorize(XRMPermissions.Accounts)]
    public class AccountsAppService :
        CrudAppService<
            Account,
            AccountDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateAccountDto,
            UpdateAccountDto>,
        IAccountsAppService
    {
        private readonly IRepository<Account> _accountRepository;

        public AccountsAppService(IRepository<Account, Guid> accountRepository) : base(accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public override Task<PagedResultDto<AccountDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return base.GetListAsync(input);
        }

        public override Task<AccountDto> GetAsync(Guid id)
        {
            return base.GetAsync(id);
        }

        [Authorize(XRMPermissions.CreateAccounts)]
        public override Task<AccountDto> CreateAsync(CreateAccountDto input)
        {
            return base.CreateAsync(input);
        }

        [Authorize(XRMPermissions.EditAccounts)]
        public override Task<AccountDto> UpdateAsync(Guid id, UpdateAccountDto input)
        {
            return base.UpdateAsync(id, input);
        }

        [Authorize(XRMPermissions.DeleteAccounts)]
        public override Task DeleteAsync(Guid id)
        {
            return base.DeleteAsync(id);
        }
    }
}
