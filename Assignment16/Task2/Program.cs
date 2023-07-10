// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using Task2;

Console.WriteLine("Create contacts list");

List<Contacts> contacts = new List<Contacts>();

while (true)
{
    Console.Write("Firstname: ");
    string firstname = Console.ReadLine();

    Console.Write("Lastname: ");
    string lastname = Console.ReadLine();

    Console.Write("Age: ");
    int age = int.Parse(Console.ReadLine());

    Contacts contact = new Contacts (firstname, lastname, age);

    contacts.Add(contact);

    Console.WriteLine("Do you want to add more contacts? Enter 'Yes' or 'No'");
    string choice = Console.ReadLine();
    {
        if (choice.ToUpper() == "No".ToUpper())
        {
            break;
        }
        else if(choice.ToUpper() == "Yes".ToUpper())
        {
            continue;
        }
        else
        {
            Console.WriteLine("Entered text is not correct. So you will no longer be able to add contacts");
            break;
        }
    }
}

Console.WriteLine();
Console.WriteLine("List of Persons:");

// Contacts in the list
foreach (Contacts contact in contacts)
{
    Console.WriteLine($"Firstname: {contact.Firstname}, Lastname: {contact.Lastname}, Age: {contact.Age}");
}

Console.WriteLine();
Console.WriteLine("Select a filter:");
Console.WriteLine("1. Search by Firstname (not exact match)");
Console.WriteLine("2. Search by Lastname (not exact match)");
Console.WriteLine("3. Search by Firstname and Lastname (not exact match)");
Console.WriteLine("4. Search by age (age range)");

int filter = int.Parse(Console.ReadLine());

string filterParameter = null;
FilterDelegate filterDelegate;

switch (filter)
{
    case 1:
        Console.WriteLine("Enter characters for the firstname");
        filterParameter = Console.ReadLine();
        filterDelegate = FilterMethods.searchFirstname;
        break;
    case 2:
        Console.WriteLine("Enter characters for the lastname");
        filterParameter = Console.ReadLine();
        filterDelegate = FilterMethods.searchLastname;
        break;
    case 3:
        Console.WriteLine("Enter characters for the firstname and lastname");
        filterParameter = Console.ReadLine();
        filterDelegate = FilterMethods.searchFirstnameLastname;
        break;
    case 4:
        Console.Write("Enter the minimum age to search: ");
        int minimumAge = int.Parse(Console.ReadLine());
        Console.Write("Enter the maximum age to search: ");
        int maximumAge = int.Parse(Console.ReadLine());
        
        filterDelegate = (contact, param) => contact.Age >= minimumAge && contact.Age <= maximumAge;
        break;
    default: 
        Console.WriteLine("Entered number is not valid.");
        return;
}


List<Contacts> filteredContacts = contacts.FindAll(contact => filterDelegate(contact, filterParameter));

Console.WriteLine();
Console.WriteLine("Filtered Contacts List:");

foreach (var contact in filteredContacts)
{
    Console.WriteLine($"Firstname: {contact.Firstname}, Lastname: {contact.Lastname}, Age: {contact.Age}");
}

delegate bool FilterDelegate(Contacts contact, string parameter);