using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestDataGeneratorLibrary;

namespace TestDataGeneratorTests
{

    public class TestDataGeneratorTests
    {
        public TestDataGenerator testDataGenerator;
        [SetUp]
        public void SetUp()
        {
            testDataGenerator = new TestDataGenerator();
        }
        [Test]
        public void TestDataGeneratorBasicTest()
        {

           TestDataGenerator tdg = new TestDataGenerator();
            Assert.IsNotNull(tdg);
        }
        [Test]
        public void GenerateRandonPersonTest()
        {
            Person person = testDataGenerator.GenerateRandonPerson();
            TestContext.WriteLine("Name : " + person.firtstName);
            Assert.IsTrue(person != null && person.firtstName != null);
 
        }

        [Test]
        public void GenerateRandonPersonInsertedNameTest()
        {
            Person person = testDataGenerator.GenerateRandonPerson("JulleTestiNimi");
            TestContext.WriteLine("Name : " + person.firtstName);
            Assert.IsTrue(person != null && person.firtstName != null);
        }

        [Test]

        public void GenerateRandonPersonInsertedLastNameTest()
        {
            List<Person> people = new List<Person>();
            Person person;
            for (int i = 0; i < 50; i++)
            {
                person = testDataGenerator.GenerateRandonPerson(lastName: "TestLastName");
                people.Add(person);
                PrintPersonData(person);
            }
            Assert.IsTrue(people.Count == 50);
        }


        [Test]
        public void GenerateNumerOfRandomPersons()
        {
            Person person;
            for (int i = 0; i < 100; i++)
            {
                person = testDataGenerator.GenerateRandonPerson();
                PrintPersonData(person);
            }
            Assert.Pass();
        }

        [Test]
        public void GenerateListOfPersons()
        {
            List<Person> people = testDataGenerator.GetListOfRandomPersons(100);
            foreach (Person person in people)
            {
                PrintPersonData(person);
            }

            Assert.IsTrue(people.Count == 100);
        }

        [Test]
        public void GetRandomFromIListTest()
        {
            List<Person> people = testDataGenerator.GetListOfRandomPersons(100);
            Person rndPerson = testDataGenerator.GetRandomFromIList(people);
            PrintPersonData(rndPerson);

            Assert.IsTrue(rndPerson != null && people.Count == 100);
        }

        public void PrintPersonData(Person person)
        {
            TestContext.WriteLine($"Name : {person.firtstName} {person.lastName}");
            TestContext.WriteLine($"Sex: {person.sex}");
            TestContext.WriteLine($"Age: {person.age}");
        }

    }
}
