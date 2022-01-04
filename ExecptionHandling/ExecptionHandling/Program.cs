using System;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * TRY CATCH BLOCK
             */
            try
            {
                DivideTwo();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sorry!!, You cant actually divide a number by zero. Try Again");
                Main(args);
            }
            catch (FormatException ex) {
                Console.WriteLine("Oops!! You need to enter a number. Try Again");
                Main(args);
            }

        }
        static void DivideTwo() {
            int num1, num2;
            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);
        }
    }
}