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
            

            Console.WriteLine(book.title);
        }
    }
}
