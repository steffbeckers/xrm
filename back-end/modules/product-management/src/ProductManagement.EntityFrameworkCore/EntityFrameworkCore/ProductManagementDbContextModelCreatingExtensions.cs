using System;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Products;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ProductManagement.EntityFrameworkCore
{
    public static class ProductManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureProductManagement(
            this ModelBuilder builder,
            Action<ProductManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ProductManagementModelBuilderConfigurationOptions(
                ProductManagementDbProperties.DbTablePrefix,
                ProductManagementDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */

            builder.Entity<Product>(b =>
            {
                // Configure table & schema name
                b.ToTable(options.TablePrefix + "Products", options.Schema);

                b.ConfigureByConvention();

                // Properties
                b.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(ProductConsts.NameMaxLength);
                b.Property(x => x.Description)
                    .HasMaxLength(ProductConsts.DescriptionMaxLength);

                // Indexes
                b.HasIndex(q => q.CreationTime);
            });
        }
    }
}