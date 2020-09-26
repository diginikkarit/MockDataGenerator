using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using PersonDataGeneratorLibrary;

namespace PersonDataGeneratorTests
{
    public class GeneratePersonWithTemplateTests
    {

        PersonDataGenerator testDataGenerator;
        [SetUp]
        public void SetUp()
        {
            testDataGenerator = new PersonDataGenerator();
        }

        [Test]
        public void GeneratePersonWithTemplateFirstName()
        {
            Person templatePerson = new Person();
            templatePerson.firstName = "Heikki";
            Person people = testDataGenerator.GenerateRandomPerson(templatePerson);
            TestHelpper.PrintPersonData(people);
            Assert.IsTrue(people.firstName == "Heikki");
        }

        [Test]
        public void GeneratePersonWithTemplateLastName()
        {
            Person templatePerson = new Person();
            templatePerson.lastName = "Mustaine";
            Person people = testDataGenerator.GenerateRandomPerson(templatePerson);
            TestHelpper.PrintPersonData(people);
            Assert.IsTrue(people.lastName == "Mustaine");
        }

        [Test]
        public void GeneratePersonsWithTemplateSex()
        {
            Person templatePerson = new Person();
            templatePerson.sex = Person.Sex.Male;
            Person people = testDataGenerator.GenerateRandomPerson(templatePerson);
            TestHelpper.PrintPersonData(people);
            Assert.IsTrue(people.sex == Person.Sex.Male);
        }

        [Test]
        public void GeneratePersonWithTemplateAge()
        {
            Person templatePerson = new Person();
            templatePerson.age = 88;
            Person people = testDataGenerator.GenerateRandomPerson(templatePerson);
            TestHelpper.PrintPersonData(people);
            Assert.IsTrue(people.age == 88);
        }

        [Test]
        public void GeneratePersonListWithTemplate()
        {
            Person templatePerson = new Person();
            templatePerson.age = 88;
            templatePerson.lastName = "Mustonen";
            List<Person> people = testDataGenerator.GetListOfRandomPersons(100, templatePerson);
            TestContext.WriteLine("\n Age should be 88 and lastName should be Mustonen");
            foreach (Person person in people)
            {
                TestHelpper.PrintPersonData(person);
            }
            Assert.IsTrue(people.Count == 100);
        }

        [Test]
        public void GeneratePersonListWithTemplateAliveTest()
        {
            Person templatePerson = new Person();
            templatePerson.isAlive = true;
            templatePerson.lastName = "Mustonen";
            List<Person> people = testDataGenerator.GetListOfRandomPersons(100, templatePerson);
            
            Assert.IsTrue(people.FindAll(x => x.isAlive == true).Count == 100);
        }


        [Test]
        public void GeneratePersonListWithTemplateIsDeadTest()
        {
            Person templatePerson = new Person();
            templatePerson.isAlive = false;
            templatePerson.lastName = "Mustonen";
            List<Person> people = testDataGenerator.GetListOfRandomPersons(100, templatePerson);

            Assert.IsTrue(people.FindAll(x => x.isAlive == false).Count == 100);
        }


    }
}
