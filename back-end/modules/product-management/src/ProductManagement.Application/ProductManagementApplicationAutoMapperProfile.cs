using AutoMapper;
using ProductManagement.Products;
using ProductManagement.Products.Dto;
using ProductManagement.Products.Eto;
using Volo.Abp.AutoMapper;

namespace ProductManagement
{
    public class ProductManagementApplicationAutoMapperProfile : Profile
    {
        public ProductManagementApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Product, ProductDto>();
            CreateMap<CreateProductDto, Product>()
                .ForMember(x => x.StockCount, x => x.Ignore())
                .ForMember(x => x.ExtraProperties, x => x.Ignore())
                .ForMember(x => x.ConcurrencyStamp, x => x.Ignore())
                .IgnoreFullAuditedObjectProperties();
            CreateMap<UpdateProductDto, Product>()
                .ForMember(x => x.StockCount, x => x.Ignore())
                .ForMember(x => x.ExtraProperties, x => x.Ignore())
                .ForMember(x => x.ConcurrencyStamp, x => x.Ignore())
                .IgnoreFullAuditedObjectProperties();
            CreateMap<Product, ProductEto>()
                .ForMember(x => x.EntityType, x => x.Ignore())
                .ForMember(x => x.KeysAsString, x => x.Ignore())
                .ForMember(x => x.Properties, x => x.Ignore());
        }
    }
}