using System;
using System.Collections.Generic;
using System.Text;

namespace Dbosoft.PipelineTest.Core;

/// <summary>
/// A class that greets people.
/// </summary>
public interface IGreeter
{
    /// <summary>
    /// Returns a normal greeting using the given <paramref name="name"/>.
    /// </summary>
    public string Greet(string name);
}
