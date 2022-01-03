using System;

namespace Dump
{
    public static class Program
    {
        static void Main(string[] args)
        {

            //simple calculator
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));

        }
    }
}