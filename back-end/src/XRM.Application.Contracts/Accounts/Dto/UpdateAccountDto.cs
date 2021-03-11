using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace XRM.Accounts.Dto
{
    public class UpdateAccountDto : EntityDto<Guid>
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100)]
        public string Telephone { get; set; }

        [StringLength(512)]
        public string Website { get; set; }
    }
}
