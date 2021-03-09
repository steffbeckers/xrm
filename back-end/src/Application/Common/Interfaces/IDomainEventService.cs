using XRM.Domain.Common;
using System.Threading.Tasks;

namespace XRM.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
