using System;
using Volo.Abp.EventBus;

namespace ProductManagement.Products.Eto
{
    [EventName("XRM.ProductManagement.ProductStockCountChanged")]
    public class ProductStockCountChangedEto
    {
        public Guid ProductId { get; }
        public int NewStockCount { get; }

        public ProductStockCountChangedEto(Guid productId, int newStockCount)
        {
            ProductId = productId;
            NewStockCount = newStockCount;
        }
    }
}
