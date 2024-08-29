using System;
using System.Collections.Generic;

internal static class Program
{
    private static void Main()
    {
        var names = new List<string> { "Alice", "Bob", "Charlie" };
        foreach (var name in names) Console.WriteLine(name);
        
        Console.ReadKey();
    }
}