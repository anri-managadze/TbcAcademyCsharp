using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class PersonList
    {
        public List<Person> _list;
        

        public PersonList()
        {
            _list = new List<Person>();
        }
        public void AddPerson (Person person) {
            _list.Add(person);
             Console.WriteLine($"You added Person: Name:{person.FirstName}, LastName:{person.LastName}, Gender:{person.Gender}, Phone:{person.Phone}");         
        }
        public void GetPerson()
        {
            if (_list.Count > 0)
            {
                foreach (Person person in _list)
                {
                    Console.WriteLine($" Name:{person.FirstName}, LastName:{person.LastName}, Gender:{person.Gender}, Phone:{person.Phone}");
                }
            } else 
            { 
                Console.WriteLine("List is Empty"); 
            }
        }
    }
}
