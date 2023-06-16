// See https://aka.ms/new-console-template for more information

using Persons;

Person[] personArray = new Person[3];

Home firstHome = new Home("Address1", "Belgrade");
Person firstPerson = new Person("Novak", 36, "131415", firstHome);
personArray[0] = firstPerson;

Home secondHome = new Home("Address2", "Tbilisi");
Person secondPerson = new Person("Khvicha", 22, "123456", secondHome);
personArray[1] = firstPerson;

Home thirdHome = new Home("Address1", "Belgrade");
Person thirdPerson = new Person("Lionel", 35, "101112", thirdHome);
personArray[2] = firstPerson;


