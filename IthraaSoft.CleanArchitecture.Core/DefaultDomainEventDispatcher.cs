using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using IthraaSoft.CleanArchitecture.Core.Generic;

using MediatR;

namespace IthraaSoft.CleanArchitecture.Core;

public class DefaultDomainEventDispatcher (IMediator mediator) : IDomainEventDispatcher
{
    private readonly IMediator mediator = mediator;

    public async Task DispatchAndClearEvents(IEnumerable<Entity> entitiesWithEvents)
    {
        foreach (var entity in entitiesWithEvents)
        {
            var domainEvents = entity.DomainEvents.ToArray();
            entity.ClearDomainEvents();

            foreach (var domainEvent in domainEvents)
            {
                await this.mediator.Publish(domainEvent).ConfigureAwait(false);
            }
        }
    }
}
