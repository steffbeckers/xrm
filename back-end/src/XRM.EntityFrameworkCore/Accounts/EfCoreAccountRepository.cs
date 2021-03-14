using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using XRM.EntityFrameworkCore;

namespace XRM.Accounts
{
    public class EfCoreAccountRepository
        : EfCoreRepository<XRMDbContext, Account, Guid>,
            IAccountRepository
    {
        public EfCoreAccountRepository(
            IDbContextProvider<XRMDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<Account> FindByNameAsync(string name)
        {
            DbSet<Account> dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(account => account.Name == name);
        }
    }
}
