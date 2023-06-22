using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    public class PersonList
    {
        private Person[] _personList;
        private int count = 0;
        private bool found = false; 

        public Person this[int i]
        {
            get
            {
                return _personList[i];
            }
            set
            {
                _personList[i] = value;
            }
        }
        public int setPersonListArray
        {
            set
            {
                _personList = new Person[value];
            }
        }
        public void AddElement(Person person)
        {
            if (count < _personList.Length)
            {
                _personList[count] = person;
                count++;
            }
            Console.WriteLine($"This person added : Title: {person.Firstname}, Author: {person.Lastname}, Year: {person.Age},Description: {person.Weight}");
        }

        public void AddList(Person[] person)
        {
            for (int i = 0; i < person.Length; i++) {
                if (count < _personList.Length)
                {
                    _personList[count] = person[i];
                    count++;
                }
                Console.WriteLine($" person added : Title: {person[i].Firstname}");
            }
        }
        public void GetElement(int index)
        {
            for (int j = 0; j < _personList.Length; j++)
            {
                if (index == j)
                {
                    Console.WriteLine("Your element is : " + _personList[j].Firstname);
                    break;
                }
            }    
        }
        public void RemoveElement(Person person)
        {
            for (int i = 0; i < _personList.Length; i++)
            {
                if (_personList[i] == person)
                {
                    _personList[i] = null;
                    count--;
                    Console.WriteLine($"{person.Firstname} This Person removed");
                    break;
                }
            }
        }
        public void RemoveList(Person[] person)
        {
            for (int i = 0; i < _personList.Length; i++)
            {
                if (_personList[i]== person[i])
                {
                    _personList[i] = null;
                    
                    Console.WriteLine($"{person[i].Firstname} This Person removed");
                    count--;
                    break;
                }
            }
        }
        public void ClearList()
        {
            for (int i = 0; i < _personList.Length; i++)
            {
                  _personList[i] = null;
                  count--;
                break; 
            }
            Console.WriteLine("List is Clear");
        }
        public string FindPerson(string i)
        {
            for (int j = 0; j < _personList.Length; j++)
            {
                if (i == _personList[j].Firstname)
                {
                    Console.WriteLine("Found: " + i);
                    break;
                }
            }
            return i;
        }
        public void PersonCount()
        {
            Console.WriteLine("Person Count :" + count);
          
        }
    }    
}
