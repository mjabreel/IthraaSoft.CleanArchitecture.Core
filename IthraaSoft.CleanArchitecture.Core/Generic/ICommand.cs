using MediatR;

namespace IthraaSoft.CleanArchitecture.Core.Generic;
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
