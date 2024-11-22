using DesignPatterns.Console.Examples;

namespace DesignPatterns.Console;

public class Program
{
    public static async Task Main(string[] args)
    {
        var example = new StrategyPatternExample();
        await example.RunExample();
    }
}