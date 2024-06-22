using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IthraaSoft.CleanArchitecture.Core.Generic;
public interface IDomainEventDispatcher
{
    Task DispatchAndClearEvents(IEnumerable<Entity> entitiesWithEvents);
}
