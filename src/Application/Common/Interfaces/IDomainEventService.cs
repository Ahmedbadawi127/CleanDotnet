using CleanDotnet.Domain.Common;
using System.Threading.Tasks;

namespace CleanDotnet.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
