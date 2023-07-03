using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class BookNotFoundException : ApplicationException
    {
        public BookNotFoundException(int id) : base($"{id} \"Book not found: \"") 
        {
            
        }
    }
}
