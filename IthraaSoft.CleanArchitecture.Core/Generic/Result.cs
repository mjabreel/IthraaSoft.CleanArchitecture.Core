using System;
using System.Threading.Tasks;

namespace IthraaSoft.CleanArchitecture.Core.Generic;

public class Result<T> : Result, IResult<T>
{
    public T? Data { get; set; }

    private Result() : base() { }

    // Factory methods for creating generic results
    public static Result<T> Success(T? data = default, string? message = "") => new()
    {
        Succeeded = true,
        Data = data,
        Messages = string.IsNullOrEmpty(message) ? [] : [message!],
    };

    public static Result<T> Failure(T? data = default, string? message = "", Exception? exception = null) => new()
    {
        Succeeded = false,
        Data = data,
        Messages = string.IsNullOrEmpty(message) ? [] : [message!],
        Exception = exception
    };

    // Async factory methods for creating generic results
    public static Task<Result<T>> SuccessAsync(T? data = default, string? message = "") => 
        Task.FromResult(Success(data, message));

    public static Task<Result<T>> FailureAsync(T? data = default, string? message = "", Exception? exception = null) => 
        Task.FromResult(Failure(data, message, exception));
}
