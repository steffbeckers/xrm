using System;
using Volo.Abp.Domain.Entities.Events.Distributed;

namespace ProductManagement.Products.Eto
{
    public class ProductEto : EntityEto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
