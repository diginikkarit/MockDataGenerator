using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using PersonDataGeneratorLibrary;

namespace PersonTests
{
    class PersonTests
    {
        [Test]
        public void isEmployedFalseTest()
        {
            Person person = new Person("Heikk", "Orlando",Person.Sex.Male,45);
            Assert.IsFalse(person.isEmployed);
        }

        [Test]
        public void isEmployedTrueTest()
        {
            Person person = new Person("Heikk", "Orlando", Person.Sex.Male, 45);
            person.occupation = "Adult entertainer";
            Assert.IsTrue(person.isEmployed);
        }
    }
}
