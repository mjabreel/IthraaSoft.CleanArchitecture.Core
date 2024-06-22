namespace IthraaSoft.CleanArchitecture.Core.Generic;

public interface IEntity<TId> : IEntity
    where TId: notnull
{
    public TId Id { get; set; }
}
