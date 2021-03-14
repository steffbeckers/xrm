using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace XRM.Accounts
{
    public class AccountAlreadyExistsException : BusinessException
    {
        public AccountAlreadyExistsException(string name)
            : base(XRMDomainErrorCodes.AccountAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
