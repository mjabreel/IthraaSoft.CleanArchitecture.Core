using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.Extensions.Logging;

namespace IthraaSoft.CleanArchitecture.Core.Behaviors;
public class LoggingBehavior<TRequest, TResponse>(ILogger<Mediator> logger) : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly ILogger<Mediator> logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        if (this.logger.IsEnabled(LogLevel.Information))
        {
            this.logger.LogInformation("Handling {RequestName}", typeof(TRequest).Name);

            // Reflection! Could be a performance concern
            var myType = request.GetType();
            var props = new List<PropertyInfo>(myType.GetProperties());

            foreach (var prop in props)
            {
                var propValue = prop?.GetValue(request, null);
                this.logger.LogInformation("Property {Property} : {@Value}", prop?.Name, propValue);
            }
        }

        var sw = Stopwatch.StartNew();

        var response = await next();

        this.logger.LogInformation("Handled {RequestName} with {Response} in {ms} ms",
            typeof(TRequest).Name, response, sw.ElapsedMilliseconds);

        sw.Stop();
        return response;
    }
}
