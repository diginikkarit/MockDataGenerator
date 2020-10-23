using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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
        public string occupation { get; set; }
        public bool isEmployed {
            get 
            {
                return (this.occupation != null) ? true : false;  
            } 
        }
        /// <summary>
        /// Instantiate a person! great!
        /// </summary>
        public Person()
        {
            isAlive = null;
        }

        public Person(string firstName=null, string lastName=null,Sex sex=0,int age=1)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sex = sex;
            this.age = age;
        }
    }
}
