using System;
using System.Collections.Generic;
using System.Text;

using MediatR;

namespace IthraaSoft.CleanArchitecture.Core.Generic;
public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
}
