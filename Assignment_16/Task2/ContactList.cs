using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ContactList
    {
        public List<Contact> _list;


        public ContactList()
        {
            _list = new List<Contact>();
        }
        public void AddContact(Contact contact)
        {
            _list.Add(contact);
          
        }
        public void GetContact()
        {
            if (_list.Count > 0)
            {
                foreach (Contact contact in _list)
                {
                    Console.WriteLine($" Name:{contact.Firstname}, LastName:{contact.Lastname}, Age:{contact.Age}");
                }
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
        }
    }
}
