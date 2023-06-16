using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _weight;

        public string Firstname
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string Lastname
        {
            get { return _lastName; }
            set
            { _lastName = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
