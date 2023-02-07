using NLogDemo;
using NLog; 

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to NLog");
        Console.WriteLine("Enter the number to be add");
        int first = Convert.ToInt32(Console.ReadLine());
        int second = Convert.ToInt32(Console.ReadLine());
        Adding.Sum(first,second);
        Console.ReadLine();
    }
}