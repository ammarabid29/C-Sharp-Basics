namespace CSharpBasics
{
    class Program
    {
        static void Main()
        {
            var p1 = new Person(
                "Ammar",
                "Abid",
                new DateOnly(2003, 02, 28)
            );
            var p2 = new Person(
                "Ali Haider",
                "Abid",
                new DateOnly(2012, 08, 25)
            );

            p1.Pets.Add(new Dog("Fred"));
            p2.Pets.Add(new Cat("Barney"));

            List<Person> personList = [p1, p2];

            foreach (var person in personList)
            {
                Console.WriteLine(person);
                foreach (var pet in person.Pets)
                {
                    Console.WriteLine("    " + pet);
                }
            }
        }
        public class Person(string firstName, string lastName, DateOnly birthday)
        {
            public string FirstName { get; } = firstName;
            public string LastName { get; } = lastName;
            public DateOnly Birthday { get; } = birthday;
            public List<Pet> Pets { get; } = [];
            public override string ToString()
            {
                return $"Person: {FirstName} {LastName}";
            }
        }

        public abstract class Pet(string name)
        {
            public string Name { get; } = name;
            public abstract string MakeNoise();
            public override string ToString()
            {
                return $"{Name} and I am a {GetType().Name} and I {MakeNoise()}";
            }
        }
        public class Cat(string name) : Pet(name)
        {
            public override string MakeNoise() => "Meow";
        }
        public class Dog(string name) : Pet(name)
        {
            public override string MakeNoise() => "Bark";
        }
    }
}