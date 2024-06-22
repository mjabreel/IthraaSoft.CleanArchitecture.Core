using System;
using System.Collections.Generic;
using System.Text;

namespace IthraaSoft.CleanArchitecture.Core;

public interface IResult
{
    IList<string> Messages { get; set; }
    bool Succeeded { get; set; }
    Exception? Exception { get; set; }
    int Code { get; set; }
}
