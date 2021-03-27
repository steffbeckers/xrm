using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Recruitment.EntityFrameworkCore
{
    public class RecruitmentModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public RecruitmentModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}