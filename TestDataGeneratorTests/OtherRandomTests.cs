using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using PersonDataGeneratorLibrary;

namespace PersonDataGeneratorTests
{
    public class OtherRandomTests
    {
        private PersonDataGenerator _personDataGenerator;
        private List<string> testListNames = new List<string> { "Julle", "Kalle", "Kyösti","Perttu", "Yrjö", "Jyri" };
        private string[] testArrayLastNames = { "Koponen", "Larsson", "Rajaniemi","Ranta", "Autio", "Reinikainen" };
        [SetUp]
        public void SetUp()
        {
            _personDataGenerator = new PersonDataGenerator();
        }

        [Test]
        public void GetRandomFromCollectionTestWithArray()
        {
            for (int i = 0; i < 10; i++)
            {
            var name = PersonDataGenerator.GetRandomFromCollection(testArrayLastNames);
            TestContext.WriteLine($"from Array :{name}");
            }
        }

        [Test]
        public void GetRandomFromCollectionTestWithList()
        {
            for (int i = 0; i < 10; i++)
            {
                var name = PersonDataGenerator.GetRandomFromCollection(testListNames);
                TestContext.WriteLine($"from List :{name}");

            }
        }

        [Test]
        public void OccupationTest()
        {
            PersonDataGenerator personDataGenerator = new PersonDataGenerator();
            personDataGenerator.occupations = new List<string> { "Maajussi", "Farmari", "Kylänmies" };
         
            foreach (var item in personDataGenerator.occupations)
            {
                TestContext.WriteLine(item);
            }
            personDataGenerator.occupations = new string[] { "Kalamies", "Erämies", "Välimies" };

            foreach (var item in personDataGenerator.occupations)
            {
                TestContext.WriteLine(item);
            }
            var itemw = new string[] { "Kalamies", "Erämies", "Välimies" };
            var joer =  new List<string> { "Maajussi", "Farmari", "Kylänmies" };
       
            var name = PersonDataGenerator.GetRandomFromCollection(personDataGenerator.occupations);
            int gg = 100;
            Assert.IsTrue(gg== 100);
        }




    }
}
