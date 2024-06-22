using System;

using MediatR;

namespace IthraaSoft.CleanArchitecture.Core;
public class DomainEvent : INotification
{
    public DateTime OccuredAt { get; set; } = DateTime.UtcNow;
}
