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

        public bool IsBestSeller() {

            return (title == "12 Rules For Life") ? true : false;
        }

        public void PrintBook() {
            string book = "Title: " + title + ", Author: " + author + ", ISBN: " + ISBN_Number + ", Pages: " + pages;
            Console.WriteLine(book);
        }

    }
}
