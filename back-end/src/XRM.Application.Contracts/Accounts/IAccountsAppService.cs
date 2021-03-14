using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using XRM.Accounts.Dto;

namespace XRM.Accounts
{
    public interface IAccountsAppService : ICrudAppService<AccountDto, Guid, PagedAndSortedResultRequestDto, CreateAccountDto, UpdateAccountDto>
    {
    }
}
