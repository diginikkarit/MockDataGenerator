using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestDataGeneratorLibrary;

namespace TestDataGeneratorTests
{
    public class OtherRandomTests
    {
        private TestDataGenerator _testDataGenerator;
        private List<string> testListNames = new List<string> { "Julle", "Kalle", "Kyösti","Perttu", "Yrjö", "Jyri" };
        private string[] testArrayLastNames = { "Koponen", "Larsson", "Rajaniemi","Ranta", "Autio", "Reinikainen" };
        [SetUp]
        public void SetUp()
        {
            _testDataGenerator = new TestDataGenerator();
        }

        [Test]
        public void GetRandomFromListTestWithArray()
        {
            for (int i = 0; i < 10; i++)
            {
            var name = _testDataGenerator.GetRandomFromIList(testArrayLastNames);
            TestContext.WriteLine($"from Array :{name}");

            }
            
        }

        [Test]
        public void GetRandomFromListTestWithList()
        {
            for (int i = 0; i < 10; i++)
            {
                var name = _testDataGenerator.GetRandomFromIList(testListNames);
                TestContext.WriteLine($"from List :{name}");

            }

        }

    }
}
