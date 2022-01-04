using System;

namespace SampleMethods {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("*** Executing SayHi()****\n");
            SayHi();
            Console.WriteLine("*** Executing SayHi(args)****\n");
            SayHi("Samuel");

            // get a maximum value
            Console.WriteLine(GetMax(4,5));
            Console.WriteLine(GetMin(4,5));
        }
        //Method with No argument 
        static void SayHi() {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi "+ name +"\n");
        }

        //Method with Argument
        static void SayHi(string name) { 
            Console.WriteLine("Hello " + name);
        }

        //Methods with Return values 
        static int GetMax(int num1, int num2) {
            // ternary operator
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else { 
                result = num2;
            }
            return result;
        }
        static int GetMin(int num1, int num2) { 
            // ternary operator // equivalent to if statements
            return (num1<num2) ? num1 : num2;
        }
    }
}