using System;
using System.Collections.Generic;
using System.Text;

namespace Dbosoft.PipelineTest.Core;

/// <summary>
/// A class that greets people.
/// </summary>
public class Greeter : IGreeter
{
    /// <inheritdoc />
    public string Greet(string name)
    {
        return $"Hello, {name}!";
    }
}
