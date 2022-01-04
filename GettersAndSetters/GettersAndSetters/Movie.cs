using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    class Movie
    {
        private string title;
        private string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating) { 
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        // SETTERS and GETTERS
        public string Rating {
            get { return rating; }
            set {
                string[] ratings= { "NR", "PG", "PG-13", "G" };
                rating = (ratings.Contains(value)) ? value : "NR";             
            }
        }

        override public string ToString() {
            return "Title: " + title + ", Director: " + director + ", Rating: " + rating;
        }

    }
}
