using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestDataGeneratorLibrary;

namespace TestDataGeneratorTests
{
    public class TestHelpper
    {

        static public void PrintPersonData(Person person)
        {
            TestContext.WriteLine($"Name : {person.firtstName} {person.lastName}");
            TestContext.WriteLine($"Sex: {person.sex}");
            TestContext.WriteLine($"Age: {person.age}");
        }

    }
}
