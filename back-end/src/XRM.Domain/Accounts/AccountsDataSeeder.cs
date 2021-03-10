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
        private readonly IRepository<Account> _accountRepository;

        public AccountsDataSeeder(IRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _accountRepository.CountAsync() == 0)
            {
                await _accountRepository.InsertManyAsync(
                    new List<Account>() {
                        new Account()
                        {
                            Name = "Steff Beckers",
                            Email = "steff@steffbeckers.eu",
                            Website = "https://steffbeckers.eu"
                        },
                        new Account()
                        {
                            Name = "aariXa",
                            Email = "info@aarixa.be",
                            Website = "https://www.aarixa.be"
                        }
                    },
                    autoSave: true
                );
            }
        }
    }
}
