using ProductManagement.Permissions;
using ProductManagement.Products.Dto;
using ProductManagement.Products.Eto;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace ProductManagement.Products
{
    public class ProductsAppService :
        CrudAppService<
            Product,
            ProductDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateProductDto,
            UpdateProductDto
        >,
        IProductsAppService
    {
        private readonly IRepository<Product, Guid> _productRepository;
        private readonly IDistributedEventBus _distributedEventBus;

        public ProductsAppService(
            IRepository<Product, Guid> productRepository,
            IDistributedEventBus distributedEventBus
        ) : base(productRepository)
        {
            _productRepository = productRepository;
            _distributedEventBus = distributedEventBus;

            GetListPolicyName = ProductManagementPermissions.Products;
            GetPolicyName = ProductManagementPermissions.Products;
            CreatePolicyName = ProductManagementPermissions.CreateProducts;
            UpdatePolicyName = ProductManagementPermissions.EditProducts;
            DeletePolicyName = ProductManagementPermissions.DeleteProducts;
        }

        public async Task ChangeStockCount(ChangeProductStockCountDto dto)
        {
            // Test
            await _distributedEventBus.PublishAsync(new ProductStockCountChangedEto(dto.ProductId, dto.NewStockCount));

            Product product = await _productRepository.FindAsync(dto.ProductId);

            // TODO: Null check here?

            product.ChangeStockCount(dto.NewStockCount);

            await _productRepository.UpdateAsync(product);
        }
    }
}
