using Task2;

Person person = new Person { Firstname="joni",Lastname= "jonidze",Age= 21,Weight= 80 };
Person person1 = new Person { Firstname="jemal",Lastname= "jemalidze",Age= 25,Weight= 70 };
Person person2 = new Person { Firstname="jimsher",Lastname= "jimsheridze",Age= 35,Weight= 100 };
Person person3 = new Person { Firstname="jeko",Lastname= "jekodze",Age= 41,Weight= 55 };

PersonList personList = new PersonList();
Person[] personsAddList = new Person[] {person,person1 };  

personList.setPersonListArray = 10;
personList.AddElement(person);
personList.AddElement(person1);
personList.AddElement(person2);
personList.AddElement(person3);

//personList.GetElement(3);
personList.AddList(personsAddList);

//personList.RemoveElement(person2);

Person[] personsRemoveList = new Person[] {person2, person3 };
personList.RemoveList(personsRemoveList);
//personList.ClearList();
personList.FindPerson("joni");
personList.PersonCount();

