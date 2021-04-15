using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace ProductManagement.Products.Dto
{
    public class ProductDto : AuditedEntityDto<Guid>//, IValidatableObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int StockCount { get; set; }
    }
}
