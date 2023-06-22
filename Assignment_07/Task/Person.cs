using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public Home Home { get; set; }


        public Person(string name, int age, string id, Home home)
        {
            Name = name;
            Age = age;
            ID = id;
            Home = home;
        }

    }
}

