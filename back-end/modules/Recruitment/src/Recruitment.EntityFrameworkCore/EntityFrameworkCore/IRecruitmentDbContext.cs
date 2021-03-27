using Microsoft.EntityFrameworkCore;
using Recruitment.Vacancies;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Recruitment.EntityFrameworkCore
{
    [ConnectionStringName(RecruitmentDbProperties.ConnectionStringName)]
    public interface IRecruitmentDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */

        DbSet<Vacancy> Vacancies { get; }
    }
}