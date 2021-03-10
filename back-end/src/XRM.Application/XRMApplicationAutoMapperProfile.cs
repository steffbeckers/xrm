using AutoMapper;
using XRM.Accounts;
using XRM.Accounts.Dto;

namespace XRM
{
    public class XRMApplicationAutoMapperProfile : Profile
    {
        public XRMApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Account, AccountDto>();
        }
    }
}
