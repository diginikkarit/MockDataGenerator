using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {
        public Person GenerateRandomPerson(Person templatePerson)
        {
            return GenerateRandomPerson(
                firstName: templatePerson.firstName,
                lastName: templatePerson.lastName,
                sex: templatePerson.sex,
                age: templatePerson.age
                );
        }

        public Person GenerateRandomPerson(string firstName = null, string lastName = null, Person.Sex sex=Person.Sex.Randomize, int age=0)
        {
            Person person = new Person();
            if(sex == Person.Sex.Randomize)
            {
               sex = GetRandomSex();
            }

            person.sex = sex;

            if (firstName == null)
            {
                if(person.sex == Person.Sex.Male)
                {
                    firstName = GetRandomFromIList(Person.firstNamesMale);
                }
                else
                {
                    firstName = GetRandomFromIList(Person.firstNameFemales);
                }
            }

            person.firstName = firstName;
            
            if(lastName == null)
            {
                lastName = GetRandomFromIList(Person.lastNames);
            }

            person.lastName = lastName;
            if(age == 0)
            {
                age = GetRandomAge();
            }
            person.age = age;
            return person;
        }

        /// <summary>
        /// Return random object of type of array,list etc....
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public T GetRandomFromIList <T>(IList<T> array)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(0, array.Count);
            return array[rndNumber];
        }

        //public T GetRandomFromIList<T>(List<T> list)
        //{
        //    Random rnd = new Random();
        //    int rndNumber = rnd.Next(0, list.Count);
        //    return list[rndNumber];
        //}

        public Person.Sex GetRandomSex()
        {
            Random rnd = new Random();
            //0 is randomize -> 1,2
            int rndNumber = rnd.Next(1,3);
            return (Person.Sex)rndNumber;
        }

        public int GetRandomAge()
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 100);
            return rndNumber;
        }

        public List<Person> GetListOfRandomPersons(int amount)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < amount; i++)
            {
                people.Add(GenerateRandomPerson());
            }
            return people;
        }

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
