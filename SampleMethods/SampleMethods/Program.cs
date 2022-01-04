using System;

namespace SampleMethods {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("*** Executing SayHi()****\n");
            SayHi();
            Console.WriteLine("*** Executing SayHi(args)****\n");
            SayHi("Samuel");
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
    }
}