using Microsoft.EntityFrameworkCore;
using Recruitment.Vacancies;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Recruitment.EntityFrameworkCore
{
    [ConnectionStringName(RecruitmentDbProperties.ConnectionStringName)]
    public class RecruitmentDbContext : AbpDbContext<RecruitmentDbContext>, IRecruitmentDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Vacancy> Vacancies { get; set; }

        public RecruitmentDbContext(DbContextOptions<RecruitmentDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureRecruitment();
        }
    }
}