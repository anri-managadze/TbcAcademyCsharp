using System;
using Task2;

var contactList = new ContactList();


while (true)
{
    Console.WriteLine("Choose: Do you need add contact ? yes | no ");

    string input = Console.ReadLine();
    switch (input) {
        case "yes":
            Console.Write("Firstname: ");
            string firstname = Console.ReadLine();

            Console.Write("Lastname: ");
            string lastname = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Contact contact = new Contact(firstname, lastname, age);

            contactList.AddContact(contact);
            break;
        case "no":
            Console.WriteLine("Contact List: ");
            contactList.GetContact();
            break;
    }
}


