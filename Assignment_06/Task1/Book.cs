using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  LibrarySystem
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _year;
        private string _description;

        public string Title { 
            get { return _title; } 
            set { _title = value;}
        }
        public string Author { 
            get { return _author;}
            set
            { _author = value;}
        }
        public int Year
        {
            get { return _year; }
            set { _year = value;}
        }
        public string Description { 
            get { return _description;}
            set { _description = value;}
        }
    }
}
