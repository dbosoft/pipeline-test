using Dbosoft.PipelineTest.Core;

Console.WriteLine("What is your name?");
Console.Write("Type your name: ");
var input = Console.ReadLine();

var greeter = new Greeter();
var greeting = greeter.Greet(input);

Console.WriteLine(greeting);
