using System;
using System.Collections.Generic;
using System.Text;

namespace IthraaSoft.CleanArchitecture.Core;

public class Result : IResult
{
    public IList<string> Messages { get; set; } = [];
    public bool Succeeded { get; set; }
    public Exception? Exception { get; set; }
    public int Code { get; set; }

    protected Result() { }

    // Factory methods for creating non-generic results
    public static Result Success(string? message = "") => new()
    {
        Succeeded = true,
        Messages = string.IsNullOrEmpty(message) ? [] : [message!]
    };

    public static Result Failure(string? message = "", Exception? exception = null) => new()
    {
        Succeeded = false,
        Messages = string.IsNullOrEmpty(message) ? [] : [message!],
        Exception = exception
    };
}

