﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using XRM.Accounts;

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
            //    b.ConfigureByConvention(); // auto configure for the base class props
            //    //...
            //});

            builder.Entity<Account>(b =>
            {
                b.ToTable(XRMConsts.DbTablePrefix + "Accounts", XRMConsts.DbSchema);
                b.ConfigureByConvention(); // auto configure for the base class props

                b.Property(p => p.Name)
                    .HasMaxLength(AccountConsts.NameMaxLength);
                b.HasIndex(p => p.Name);

                b.Property(p => p.Email)
                    .HasMaxLength(AccountConsts.EmailMaxLength);
                
                b.Property(p => p.Telephone)
                    .HasMaxLength(AccountConsts.TelephoneMaxLength);

                b.Property(p => p.Website)
                    .HasMaxLength(AccountConsts.WebsiteMaxLength);
            });
        }
    }
}