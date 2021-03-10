using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace XRM.Accounts
{
    public class Account : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// The account name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The account's e-mail address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The account's telephone number.
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// The account's website URL.
        /// </summary>
        public string Website { get; set; }
    }
}
