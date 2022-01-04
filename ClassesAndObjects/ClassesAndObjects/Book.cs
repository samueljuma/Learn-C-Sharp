using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Book
    {
        public string title;
        public string author;
        public string ISBN_Number;
        public int pages;

        /*
         * Constructors 
         */
        public Book(string title, string author, string ISBN_number, int pages) { 
            this.title = title;
            this.author = author;
            this.ISBN_Number = ISBN_number;
            this.pages = pages;
        }
        
    }
}
