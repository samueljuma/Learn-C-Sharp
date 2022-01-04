using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args) { 
            Book book = new Book("12 Rules For Life", "Jordan Peterson","RG54",100);
            /*
             * 
            if (book.IsBestSeller() == true)
            {
                Console.WriteLine(book.title + " is a bestSeller");
            }
            else {
                Console.WriteLine(book.title + " is not a bestSeller");
            }
            *
            */
            
            // call PrintBook 
            book.PrintBook();

        }
    }
}
