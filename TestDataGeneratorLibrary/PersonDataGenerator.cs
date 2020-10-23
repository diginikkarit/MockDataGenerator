using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace PersonDataGeneratorLibrary
{
    public class PersonDataGenerator
    {
        public ICollection<string> occupations = new string[] { "Fireman", "Laywer", "Teamster", "Tax Inspector" };
        /// <summary>
        /// A pool of male first names which this instance of PersonDataGenerator can use.
        /// Replace with your own names if needed.
        /// </summary>
        public ICollection<string> firstNamesMale = new List<string> {"Miro", "John", "Ben", "Alex", "Ronald", "Emmet", "Gary", "Brad", "Bernard" };
        /// <summary>
        /// A pool of female first names which this instance of PersonDataGenerator can use.
        /// Replace with your own names if needed.
        /// </summary>
        public ICollection<string> firstNamesFemale = new string[] {"Isla","Helena","Karla","Heidi","Aliisa","Alice", "Olga" };
        /// <summary>
        /// A pool of lastnames which this instance of PersonDataGenerator can use.
        /// Replace with your own names if needed.
        /// </summary>
        public ICollection<string> lastNames =new List<string>{ "Mustaine", "Ewing", "Brady", "mcLeod", "Simpson", "Parker", "Banner" };
        private static Random rndGenerator;
        /// <summary>
        /// Generates one randomized object of Person class. Uses names from name pools, age is between 1-99, isAlive is true or false.
        /// </summary>
        /// <param name="templatePerson">
        /// You can use Person class object as a template. Example : Only last name is set in Person, all generated Person objects have the same last name. 
        /// </param>
        /// <returns>Person class object with randomized names, age etc.</returns>
        public Person GenerateRandomPerson(Person templatePerson)
        {
            return GenerateRandomPerson(
                firstName: templatePerson.firstName,
                lastName: templatePerson.lastName,
                sex: templatePerson.sex,
                age: templatePerson.age,
                isAlive: templatePerson.isAlive,
                occupation: templatePerson.occupation
                );
        }

        static PersonDataGenerator()
        {
            rndGenerator = new Random();
        }

        public PersonDataGenerator()
        {
            occupations = new string[] { "Fireman", "Laywer", "Teamster", "Tax Inspector" };
            firstNamesMale = new string[] { "Miro", "John", "Ben", "Alex", "Ronald", "Emmet", "Gary", "Brad", "Bernard" };
            firstNamesFemale = new string[] { "Karla", "Alicia", "Alexy", "Lisa", "Alisa", "Helena", "Heidi", "Hanna","Isla","Tina","Fiona" };
        }

        /// <summary>
        /// If Parameter is empty, PersonDataGenerator uses default pool.
        /// </summary>
        /// <param name="occupations"></param>
        /// <param name="firstNamesMale"></param>
        /// <param name="firstNamesFemale"></param>
        /// <param name="lastNames"></param>
        public PersonDataGenerator(ICollection<string> occupations = null, ICollection<string> firstNamesMale=null, ICollection<string> firstNamesFemale=null, ICollection<string> lastNames=null)
        {
            if(occupations != null) this.occupations = occupations;
            if(firstNamesMale != null) this.firstNamesMale = firstNamesMale;
            if(firstNamesFemale != null) this.firstNamesFemale = firstNamesFemale;
            if (lastNames != null) this.lastNames = lastNames;
        }

        /// <summary>
        /// Fill out the parameters that you want to set. Everything else will be randomized.
        /// </summary>
        /// <param name="firstName">If not provided, will be random.</param>
        /// <param name="lastName">If not provided, will be random.</param>
        /// <param name="sex">If not provided, will be random.</param>
        /// <param name="age">If not provided, will be random.</param>
        /// <param name="isAlive">If not provided, will be random.</param>
        /// <param name="occupation"> --- not defined ---</param>
        /// <returns></returns>
        public Person GenerateRandomPerson(string firstName = null, string lastName = null, Person.Sex sex = Person.Sex.Randomize, int age = 0, bool? isAlive = null,string occupation = null)
        {
            Person person = new Person();
            if (sex == Person.Sex.Randomize)
            {
                sex = GetRandomSex();
            }

            person.sex = sex;

            if (firstName == null)
            {
                if (person.sex == Person.Sex.Male)
                {

                    firstName = GetRandomFromCollection(firstNamesMale);
                }
                else
                {
                    firstName = GetRandomFromCollection(firstNamesFemale);
                }
            }

            person.firstName = firstName;

            if (lastName == null)
            {
                lastName = GetRandomFromCollection(lastNames);
            }

            person.lastName = lastName;
            if (age == 0)
            {
                age = GetRandomAge();
            }
            person.age = age;

            person.isAlive = isAlive;
            if (person.isAlive == null)
            {
                person.isAlive = rndGenerator.Next(0, 2) == 1;
            }

            person.occupation = occupation;
            if (String.IsNullOrEmpty(person.occupation))
            {
                person.occupation = GetRandomFromCollection(this.occupations);
            }

            return person;
        }

        /// <summary>
        /// Return random object from ICollection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static T GetRandomFromCollection<T>(ICollection<T> array)
        {
            int rndNumber = rndGenerator.Next(0, array.Count);
            return array.ToList<T>()[rndNumber];
        }

        //public T GetRandomFromIList<T>(List<T> list)
        //{
        //    Random rnd = new Random();
        //    int rndNumber = rnd.Next(0, list.Count);
        //    return list[rndNumber];
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Sex enum Male or Female</returns>
        public Person.Sex GetRandomSex()
        {
            int rndNumber = rndGenerator.Next(1,3);
            return (Person.Sex)rndNumber;
        }

        /// <summary>
        /// Returns an int between minValue and maxValue
        /// Defaults to 1-99 if no values are given.
        /// </summary>
        /// <param name="minValue">Defaults to 1</param>
        /// <param name="maxValue">Defaults to 100</param>
        /// <returns></returns>
        static public int GetRandomAge(int minValue = 1, int maxValue = 100)
        {
            if (maxValue > 100) maxValue = 100;
            if (minValue < 1) minValue = 1;
            int rndNumber = rndGenerator.Next(minValue, maxValue);
            return rndNumber;
        }

        /// <summary>
        /// Returns a List of Randomly generated Person class objects.
        /// </summary>
        /// <param name="amount">Number to be generated.</param>
        /// <returns></returns>
        public List<Person> GetListOfRandomPersons(int amount)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < amount; i++)
            {
                people.Add(GenerateRandomPerson());
            }
            return people;
        }

        /// <summary>
        /// Returns a List of Randomly generated Person class objects.
        /// </summary>
        /// <param name="amount">Number to be generated.</param>
        /// <param name="templatePerson">All generated object will be generated using this object as template.</param>
        /// <returns></returns>
        public List<Person> GetListOfRandomPersons(int amount, Person templatePerson)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < amount; i++)
            {
                people.Add(GenerateRandomPerson(templatePerson));
            }
            return people;
        }
    }
}
