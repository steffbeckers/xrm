using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace XRM.Accounts
{
    public class AccountManager : DomainService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountManager(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Account> CreateAsync(
            [NotNull] string name,
            [CanBeNull] string email = null,
            [CanBeNull] string telephone = null,
            [CanBeNull] string website = null)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var existingAccount = await _accountRepository.FindByNameAsync(name);
            if (existingAccount != null)
            {
                throw new AccountAlreadyExistsException(name);
            }

            return new Account(
                GuidGenerator.Create(),
                name,
                email,
                telephone,
                website
            );
        }

        public async Task ChangeNameAsync(
            [NotNull] Account account,
            [NotNull] string newName)
        {
            Check.NotNull(account, nameof(account));
            Check.NotNullOrWhiteSpace(newName, nameof(newName));

            var existingAccount = await _accountRepository.FindByNameAsync(newName);
            if (existingAccount != null && existingAccount.Id != account.Id)
            {
                throw new AccountAlreadyExistsException(newName);
            }

            account.ChangeName(newName);
        }
    }
}
