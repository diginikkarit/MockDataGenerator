using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataGeneratorLibrary
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Sex sex { get; set; }

        public int age { get; set; }
        public bool? isAlive { get; set; }

        public enum Sex { Randomize = 0, Male ,  Female };

        /// <summary>
        /// isAlive : bool attribute is nullable and null by default.
        /// </summary>
        public Person()
        {
            isAlive = null;
        }
    }
}
