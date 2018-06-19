using Clients.CalculatorService;
using System;

namespace Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CalculatorServiceClient proxy = new CalculatorServiceClient())
            {
                Console.Write($"when x = {1} and y = {2}: ");
                Console.Write($"x + y = {proxy.Add(1, 2)}, ");
                Console.Write($"x - y = {proxy.Subtract(1, 2)}, ");
                Console.Write($"x * y = {proxy.Multiply(1, 2)}, ");
                Console.WriteLine($"x / y = {proxy.Divide(1, 2)}.");
            }
        }
    }
}
