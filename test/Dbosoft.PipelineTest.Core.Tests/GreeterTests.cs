using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbosoft.PipelineTest.Core.Tests;

public class GreeterTests
{
    private readonly IGreeter _greeter = new Greeter();

    [Fact]
    public void Greet_WithName_ReturnsGreeting()
    {
        var result = _greeter.Greet("John");

        Assert.Equal("Hello, John!", result);
    }
}
