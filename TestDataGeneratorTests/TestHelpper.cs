using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;
using PersonDataGeneratorLibrary;

namespace PersonDataGeneratorTests
{
    public class TestHelpper
    {

        static public void PrintPersonData(Person person)
        {
            TestContext.WriteLine($"Name : {person.firstName} {person.lastName}");
            TestContext.WriteLine($"Sex: {person.sex}");
            TestContext.WriteLine($"Age: {person.age}");
            TestContext.WriteLine($"Alive: {person.isAlive}");
            TestContext.WriteLine($"Occupation: {person.occupation}");
        }

        static public void PrintPersonDataList(List<Person> list)
        {
            foreach (Person person in list)
            {
                PrintPersonData(person);
                TestContext.WriteLine();
            }
        }

        static public void PrintPersonDataGeneratorDataLists(PersonDataGenerator personDataGenerator)
        {
            TestContext.WriteLine($"Occupations : {PrintICollection(personDataGenerator.occupations)}");
            TestContext.WriteLine($"Male first names : {PrintICollection(personDataGenerator.firstNamesMale)}");
            TestContext.WriteLine($"Female fisrt names : {PrintICollection(personDataGenerator.firstNamesFemale)}");
            TestContext.WriteLine($"Last names : {PrintICollection(personDataGenerator.lastNames)}");
        }

        static private string PrintICollection(ICollection<string> collection)
        {
            string msg = "";
            foreach (string item in collection)
            {
                msg += item.ToString() + ",";
            }

            //Remove last ','
            msg = msg.Substring(0, msg.Length - 1);

            return msg;
        }

    }
}
