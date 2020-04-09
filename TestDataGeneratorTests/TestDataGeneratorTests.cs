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
                TestHelpper.PrintPersonData(person);
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
                TestHelpper.PrintPersonData(person);
            }
            Assert.Pass();
        }

        [Test]
        public void GenerateListOfPersons()
        {
            List<Person> people = testDataGenerator.GetListOfRandomPersons(100);
            foreach (Person person in people)
            {
                TestHelpper.PrintPersonData(person);
            }

            Assert.IsTrue(people.Count == 100);
        }

     


        [Test]
        public void GenerateRandomPersonWithGenderMale()
        {
            Person person;
            
            TestContext.WriteLine("Randomized sex");
            for (int i = 0; i < 10; i++)
            {
                person = testDataGenerator.GenerateRandonPerson(sex : Person.Sex.Randomize);
                TestHelpper.PrintPersonData(person);
            }

            TestContext.WriteLine("\nMales");
            for (int i = 0; i < 10; i++)
            {
                person = testDataGenerator.GenerateRandonPerson(sex: Person.Sex.Male);
                TestHelpper.PrintPersonData(person);
            }

            TestContext.WriteLine("\n Females");
            for (int i = 0; i < 10; i++)
            {
                person = testDataGenerator.GenerateRandonPerson(sex: Person.Sex.Female);
                TestHelpper.PrintPersonData(person);
            }
        }


        [Test]
        public void GetRandomFromIListTest()
        {
            List<Person> people = testDataGenerator.GetListOfRandomPersons(100);
            Person rndPerson = testDataGenerator.GetRandomFromIList(people);
            TestHelpper.PrintPersonData(rndPerson);

            Assert.IsTrue(rndPerson != null && people.Count == 100);
        }

        [Test]
        public void GetRandomPersonWithRandomAge()
        {
            Person rndPerson = testDataGenerator.GenerateRandonPerson(age:0);
            TestHelpper.PrintPersonData(rndPerson);
            Assert.IsTrue(rndPerson.age > 0);
        }

        public void GetRandomPersonWithAge()
        {
            Person rndPerson = testDataGenerator.GenerateRandonPerson(age: 66);
            TestHelpper.PrintPersonData(rndPerson);
            Assert.IsTrue(rndPerson.age == 66);
        }


    }
}
