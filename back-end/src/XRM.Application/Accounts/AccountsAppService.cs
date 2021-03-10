using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using XRM.Accounts.Dto;

namespace XRM.Accounts
{
    public class AccountsAppService : ApplicationService, IAccountsAppService
    {
        private readonly IRepository<Account> _accountRepository;

        public AccountsAppService(IRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<ListResultDto<AccountDto>> GetList()
        {
            List<Account> accounts = await _accountRepository.GetListAsync();
            return new ListResultDto<AccountDto>(ObjectMapper.Map<List<Account>, List<AccountDto>>(accounts));
        }
    }
}
