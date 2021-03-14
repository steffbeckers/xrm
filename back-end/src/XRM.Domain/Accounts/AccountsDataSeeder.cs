using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace XRM.Accounts
{
    public class AccountsDataSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly AccountManager _accountManager;
        private readonly IRepository<Account> _accountRepository;

        public AccountsDataSeeder(
            AccountManager accountManager,
            IRepository<Account> accountRepository
        )
        {
            _accountManager = accountManager;
            _accountRepository = accountRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _accountRepository.CountAsync() == 0)
            {
                Account steffBeckersAccount = await _accountManager.CreateAsync(
                    "Steff Beckers",
                    "steff@steffbeckers.eu",
                    "+32 499 765 192",
                    "https://steffbeckers.eu"
                );

                Account aariXaAccount = await _accountManager.CreateAsync(
                    "aariXa",
                    "info@aarixa.be",
                    null,
                    "https://www.aarixa.be"
                );

                await _accountRepository.InsertManyAsync(
                    new List<Account>() {
                        steffBeckersAccount,
                        aariXaAccount
                    },
                    autoSave: true
                );
            }
        }
    }
}
