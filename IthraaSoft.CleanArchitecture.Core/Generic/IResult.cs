using System;
using System.Collections.Generic;
using System.Text;

namespace IthraaSoft.CleanArchitecture.Core.Generic;

public interface IResult<T> : IResult
{
    T? Data { get; set; }
}
