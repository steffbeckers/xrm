using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace XRM.Accounts.Dto
{
    public class CreateAccountDto : EntityDto<Guid?>
    {
        [Required]
        [StringLength(AccountConsts.NameMaxLength)]
        public string Name { get; set; }

        [EmailAddress]
        [StringLength(AccountConsts.EmailMaxLength)]
        public string Email { get; set; }

        [StringLength(AccountConsts.TelephoneMaxLength)]
        public string Telephone { get; set; }

        [StringLength(AccountConsts.WebsiteMaxLength)]
        public string Website { get; set; }
    }
}
