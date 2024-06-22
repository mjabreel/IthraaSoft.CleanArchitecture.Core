using MediatR;

namespace IthraaSoft.CleanArchitecture.Core.Generic;
public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse> 
    where TCommand : ICommand<TResponse>
{
}
