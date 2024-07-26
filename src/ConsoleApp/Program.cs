
// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using System.Linq.Expressions;

Console.WriteLine("Hello, World of .NET 6!");

if(args.Length != 0) {
    Console.Write("Arguments: ");
    for (int i = 0; i < args.Length; i++)
    {
        Console.Write($"{args[i]} ");
    }

    Console.WriteLine();

    Calculator ca = new Calculator();

    int x = (args[0] == null ? 0 : Convert.ToInt32(args[0]));
    int y;
    try{
        y = (args[1] == null ? 0 : Convert.ToInt32(args[1]));
    }
    catch(IndexOutOfRangeException ex) {
        y = 0;
    }

    int? area = ca.CalculateArea(x, y);

    Console.WriteLine($"Area of {x} and {y} is {area}");
};


