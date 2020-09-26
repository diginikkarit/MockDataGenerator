using NUnit.Framework;
using PersonDataGeneratorLibrary;
using PersonDataGeneratorTests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TestDataGeneratorTests
{
    public class PersonDataGeneratorConstructorTests
    {
        public List<string> testOccupationList = new List<string>() { "Miner", "Pilot", "Construction worker" };

        [SetUp]
        public void SetUp()
        {

        }

        [TestCase(new string[] {"Miner", "Pilot", "Construction worker" },null,null,null)]
        [TestCase(null, new string[] { "Teppo", "Seppo", "Matti" }, null, null )]
        [TestCase(null, null, new string[] { "Hellu", "Kaarina", "Saila" }, null)]
        [TestCase(null, null,null, new string[] { "Romppainen", "Limingoja", "Häikiö" })]
        public void PersonDataGeneratorConstructorTestWithOccupationList(ICollection<string> occupations, ICollection<string> firstNamesMale,ICollection<string> firstNamesFelmale, ICollection<string> lastNames)
        {
            PersonDataGenerator pdg = new PersonDataGenerator(occupations, firstNamesMale, firstNamesFelmale,lastNames);
            TestHelpper.PrintPersonDataGeneratorLists(pdg);
            Assert.IsTrue(pdg.occupations != null && pdg.firstNamesMale != null && pdg.firstNamesFemale != null && pdg.lastNames != null); 
        }
    }
}
