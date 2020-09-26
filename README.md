# PersonDataGeneratorLibrary
With this light C# library you can generate data for testing and practising purposes.
You can quicky generate personal data collections with randomised names, ages, occupations etc.
Designed for there and similair purposes:
   - Generate data to practice your LINQ-skills.
   - Generate data for testing and developing your applications.
   - Create populations of people to play around with.

# Classes

### Person
Holds data of a single person. 
- firstName : string
- lastName : string
- occupation : string
- age : int
- Sex : Enum
- isAlive : bool? (nullable)

### PersonDataGenerator
Generates randomized or partially randomized Person objects. 

***quick and dirty example***
```sh
PersonDataGenerator pdg = new PersonDataGenerator();
List<Person> people = pgd.GetListOfRandomPersons(100);
Person randomPerson = pgd.GenerateRandomPerson();
```
