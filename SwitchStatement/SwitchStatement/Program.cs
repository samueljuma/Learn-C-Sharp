using System;

namespace SwitchStatement {
    public class Program {
        static void Main(string[] args) {

            Console.WriteLine("********** SIMPLE CALULATOR ***********");
            //first num
            Console.Write("Enter First Number: ");
            int num1= Convert.ToInt32(Console.ReadLine());
            //operation
            Console.Write("Enter Operation: ");
            char op = Convert.ToChar(Console.ReadLine());
            //second num
            Console.Write("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (op) {
                case '+':
                    Console.WriteLine(num1+num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '%':
                    Console.WriteLine(num1 % num2);
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }

            
        }
    }
}
