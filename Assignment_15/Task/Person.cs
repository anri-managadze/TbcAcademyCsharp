using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _gender;
        private string _phone;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }


        public Person(string firstName, string lastName, string gender, string phone)
        {
            _firstName = firstName;
            _lastName = lastName;
            _gender = gender;
            _phone = phone;
        }
    }
}
