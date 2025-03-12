using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    public class Book
    {
        //classes have member variables, or "fields" to hold data
        string _name;
        string _author;
        int _pagecount;

        // classes have one or more constructors
        //creates an object of this classes type.
        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;

        }
        // Methods are used to operate the class and data:
        public string GetDestription()
        {
            return $"{_name} by {_author} has {_pagecount} pages";
        }
    }
}
