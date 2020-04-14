using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Sex sex { get; set; }

        public int age { get; set; }
        public bool alive { get; set; }

        public enum Sex { Randomize = 0, Male ,  Female };
        public static string[] firstNamesMale = { "John", "Ben", "Alex", "Ronald", "Emmet", "Gary","Brad","Bernard" };
        public static string[] firstNameFemales = { "Sally", "Madison", "Ella", "Barbie", "Jenny", "Elvira","Bella","Brianna" };
        public static string[] lastNames = { "Mustaine", "Ewing", "Brady", "mcLeod", "Simpson", "Parker", "Banner" };
    }
}
