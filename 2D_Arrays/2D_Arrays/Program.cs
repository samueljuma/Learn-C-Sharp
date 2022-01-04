using System;

namespace Arrays_2D{
    public class Program {
        static void Main(string[] args) {
            int[,] a =
            {
                { 1, 2 },
                { 3, 4 },
                { 4, 5 },
            };

            int[,] b = new int[3,5];
            b[0,0] = 100;


            Console.WriteLine(a[0,0]);
            Console.WriteLine(b[0,0]);
        }
    }
}