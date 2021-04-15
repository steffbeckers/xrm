using ProductManagement.Products.Dto;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ProductManagement.Products
{
    public interface IProductsAppService : ICrudAppService<ProductDto, Guid, PagedAndSortedResultRequestDto, CreateProductDto, UpdateProductDto>
    {
        Task ChangeStockCount(ChangeProductStockCountDto dto);
    }
}
