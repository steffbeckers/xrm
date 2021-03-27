using System;
using Microsoft.EntityFrameworkCore;
using Recruitment.Vacancies;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Recruitment.EntityFrameworkCore
{
    public static class RecruitmentDbContextModelCreatingExtensions
    {
        public static void ConfigureRecruitment(
            this ModelBuilder builder,
            Action<RecruitmentModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new RecruitmentModelBuilderConfigurationOptions(
                RecruitmentDbProperties.DbTablePrefix,
                RecruitmentDbProperties.DbSchema
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

            builder.Entity<Vacancy>(b =>
            {
                // Configure table & schema name
                b.ToTable(options.TablePrefix + "Vacancies", options.Schema);

                b.ConfigureByConvention();

                // Properties
                b.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(VacancyConsts.NameMaxLength);

                // Indexes
                b.HasIndex(q => q.CreationTime);
            });
        }
    }
}