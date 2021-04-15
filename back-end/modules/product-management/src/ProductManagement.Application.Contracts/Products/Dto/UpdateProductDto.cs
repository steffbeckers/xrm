using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace ProductManagement.Products.Dto
{
    public class UpdateProductDto : EntityDto<Guid>
    {
        [Required]
        [StringLength(ProductConsts.NameMaxLength)]
        public string Name { get; set; }

        [StringLength(ProductConsts.DescriptionMaxLength)]
        public string Description { get; set; }
    }
}
