using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Book
    {
        private int _id;
        private string _title;
        private string _autor;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title {get { return _title; } set { _title = value; } }
        public string Author{get { return _autor; } set { _autor = value; } }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            if (id == 0)
            {
                throw new ArgumentNullException("Id is Mandatory");
            } if (title == null)
            {
                throw new ArgumentNullException("Title is Mandatory");
            }
            if(author == null)
            {
                throw new ArgumentNullException("Author is Mandatory");
            }
        }

    }
}
