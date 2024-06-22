using MediatR;

namespace IthraaSoft.CleanArchitecture.Core.Generic;
public interface IQuery<out TResponse> : IRequest<TResponse>
{
}
