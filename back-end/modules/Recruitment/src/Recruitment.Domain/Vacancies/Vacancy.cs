using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Recruitment.Vacancies
{
    public class Vacancy : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// The vacancy name.
        /// </summary>
        public string Name { get; set; }

        private Vacancy()
        {
            // This constructor is for deserialization / ORM purpose
        }

        public Vacancy(
            Guid id,
            [NotNull] string name,
            [CanBeNull] string email = null,
            [CanBeNull] string telephone = null,
            [CanBeNull] string website = null) : base(id)
        {
            SetName(name);
        }

        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(
                name,
                nameof(name),
                maxLength: VacancyConsts.NameMaxLength
            );
        }
    }
}
