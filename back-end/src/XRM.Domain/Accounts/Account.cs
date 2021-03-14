using JetBrains.Annotations;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace XRM.Accounts
{
    public class Account : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// The account name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The account's e-mail address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The account's telephone number.
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// The account's website URL.
        /// </summary>
        public string Website { get; set; }

        private Account()
        {
            // This constructor is for deserialization / ORM purpose
        }

        public Account(
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
                maxLength: AccountConsts.NameMaxLength
            );
        }

        public Account ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }
    }
}
