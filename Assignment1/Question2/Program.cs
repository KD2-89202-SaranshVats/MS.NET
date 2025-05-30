using System;
namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(args[0]);
            string op = args[1];
            int num2 = int.Parse(args[2]);
            int result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!");
                    break;
            }
            Console.WriteLine($"{num1} {op} {num2} = {result}");
        }
    }
}
