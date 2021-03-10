using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace XRM.Accounts.Dto
{
    public class AccountDto : AuditedEntityDto
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
