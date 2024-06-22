using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IthraaSoft.CleanArchitecture.Core;
public abstract class EntityWithDomainEvents
{
    private readonly List<DomainEvent> domainEvents = [];

    [NotMapped]
    public IEnumerable<DomainEvent> DomainEvents => 
        this.domainEvents.AsReadOnly();

    protected void RegisterDomainEvent(DomainEvent domainEvent) => 
        this.domainEvents.Add(domainEvent);

    internal void ClearDomainEvents() => this.domainEvents.Clear();
}
