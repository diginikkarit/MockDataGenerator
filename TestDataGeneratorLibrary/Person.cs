using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class Person
    {
        public static List<string> rndNames = new List<string>() { "Julle", "Dulle", "Doff" };

        public string firtstName { get; set; }
        public string lastName { get; set; }
        public Sex sex { get; set; }

        public int age { get; set; }
        public bool alive { get; set; }

        public enum Sex { male = 0, female};
        public static string[] firstNamesMale = { "John", "Ben", "Alex", "Ronald", "Emmet", "Gary" };
        public static string[] firstNameFemales = { "Sally", "Madison", "Ella", "Barbie", "Jenny", "Elvira" };
        public static string[] lastNames = { "Mustaine", "Ewing", "Brady", "mcLeod", "Simpson", "Parker", "Banner" };
        public static int[] rndNumber = { 64, 124, 42, 88, 69 };
    }
}
