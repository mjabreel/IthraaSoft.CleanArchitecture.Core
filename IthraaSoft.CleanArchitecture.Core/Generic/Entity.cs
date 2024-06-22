using System;
using System.Collections.Generic;
using System.Text;

namespace IthraaSoft.CleanArchitecture.Core.Generic;
public abstract class Entity<TId> : EntityWithDomainEvents, IEntity, IEntity<TId>
    where TId : notnull
{

    public TId Id { get; set; }
}
