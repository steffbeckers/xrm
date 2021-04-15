using System;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Products.Dto
{
    public class ChangeProductStockCountDto
    {
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public int NewStockCount { get; set; }
    }
}
