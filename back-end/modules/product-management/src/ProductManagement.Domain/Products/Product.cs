using JetBrains.Annotations;
using ProductManagement.Products.Eto;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace ProductManagement.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// The product name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The product's description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The product's stock count.
        /// </summary>
        public int StockCount { get; private set; }

        public Product()
        {
            // This constructor is for deserialization / ORM purpose
        }

        public Product(
            Guid id,
            [NotNull] string name,
            [CanBeNull] string description = null) : base(id)
        {
            SetName(name);
            Description = description;
        }

        public void ChangeStockCount(int newStockCount)
        {
            StockCount = newStockCount;
            AddDistributedEvent(new ProductStockCountChangedEto(Id, newStockCount));
        }

        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(
                name,
                nameof(name),
                maxLength: ProductConsts.NameMaxLength
            );
        }
    }
}
