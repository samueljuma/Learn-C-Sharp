using System;

namespace Loops {
    public class Program {
        static void Main(string[] args) { 
            int index = 0;
            // While Loop
           
            while (index < 5) { 
                Console.WriteLine("Iteration" + index);
                index++;
            }

            // For Loop
            for (int i = 0; i <= 5; i++) {
                Console.WriteLine("Iteration" + i); 
            }
        }

        

        
    }
}