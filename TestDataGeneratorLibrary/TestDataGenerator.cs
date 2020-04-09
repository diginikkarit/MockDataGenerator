using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {
        public Person GenerateRandonPerson(Person templatePerson)
        {
            return GenerateRandonPerson(
                fisrtName: templatePerson.firtstName,
                lastName: templatePerson.lastName,
                sex: templatePerson.sex,
                age: templatePerson.age
                );
        }

        public Person GenerateRandonPerson(string fisrtName = null, string lastName = null, Person.Sex sex=Person.Sex.Randomize, int age=0)
        {
            Person person = new Person();
            if(sex == Person.Sex.Randomize)
            {
               sex = GetRandomSex();
            }

            person.sex = sex;

            if (fisrtName == null)
            {
                if(person.sex == Person.Sex.Male)
                {
                    fisrtName = GetRandomFromIList(Person.firstNamesMale);
                }
                else
                {
                    fisrtName = GetRandomFromIList(Person.firstNameFemales);
                }
            }

            person.firtstName = fisrtName;
            
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
                people.Add(GenerateRandonPerson());
            }
            return people;
        }

        public List<Person> GetListOfRandomPersons(int amount, Person templaterPerson)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < amount; i++)
            {
                people.Add(GenerateRandonPerson(templaterPerson));
            }
            return people;
        }

    }
}
