using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace XRM.EntityFrameworkCore
{
    public static class XRMDbContextModelCreatingExtensions
    {
        public static void ConfigureXRM(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(XRMConsts.DbTablePrefix + "YourEntities", XRMConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}