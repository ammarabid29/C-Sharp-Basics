namespace CSharpBasics
{
    class Program
    {
        static void Main()
        {
            int age;
            Console.Write("Enter your age: ");
            string? input = Console.ReadLine();
            if (input != null)
            {
                age = int.Parse(input);
                Console.WriteLine($"You are {age + 1} years old.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            int check = 1;
            do
            {
                Console.WriteLine(check);
                check++;
            }
            while (check <= 5);

            string message =(2<4)?"Valid message":"Invalid message";
            Console.WriteLine(message);

            string? select;
            Console.Write("Enter a number b/w 1-3: ");
            select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Console.WriteLine("You selected 1.");
                    break;
                case "2":
                    Console.WriteLine("You selected 2.");
                    break;
                case "3":
                    Console.WriteLine("You selected 3.");
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }


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