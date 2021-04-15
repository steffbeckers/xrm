using Microsoft.Extensions.Logging;
using ProductManagement.Products.Eto;
using System.Threading.Tasks;
using Volo.Abp.EventBus.Distributed;

namespace ProductManagement.Products
{
    // Test event handler
    public class ProcessProductStockChange : IDistributedEventHandler<ProductStockCountChangedEto>
    {
        private readonly ILogger<ProcessProductStockChange> _logger;

        public ProcessProductStockChange(ILogger<ProcessProductStockChange> logger)
        {
            _logger = logger;
        }

        public Task HandleEventAsync(ProductStockCountChangedEto eventData)
        {
            _logger.LogInformation($"ProductStockCountChanged event received. ProductId: {eventData.ProductId}, NewStockCount: {eventData.NewStockCount}");

            return Task.CompletedTask;
        }
    }
}
