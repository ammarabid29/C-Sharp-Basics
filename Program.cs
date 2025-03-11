namespace CSharpBasics
{
    class Program
    {
        static void Main()
        {
            /*
            var name = "Ammar";
            Console.WriteLine(name);
            Console.WriteLine(name.GetType());

            //determine datatype on runtime 
            dynamic age = 10;
            Console.WriteLine(age);
            Console.WriteLine(age.GetType());

            age = "Ten";
            Console.WriteLine(age);
            Console.WriteLine(age.GetType());

            MyMethod("Ammar");
            MyMethod("Ali", 5);

            int value1 = 10;
            PassByValue(value1);
            Console.WriteLine($"MainValue: {value1}");

            int value2 = 10;
            PassByReference(ref value2);
            Console.WriteLine($"MainValue: {value2}");

            int value3;
            PassByOut(out value3);
            Console.WriteLine($"MainValue: {value3}");

            //Array is always passed as reference so its value will be changed in the main method as well
            int[] array = { 1, 2, 3, 4, 5 };
            MyArrayMethod(array);
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }

            Demo("Ammar");
            Demo(10);

            string answer = ReturnMethod(10, 20);
            Console.WriteLine(answer);

            string? name;
            int? index;
            Gender? gender;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("0 Male, 1 Female, 2 Other\n");
            index = int.Parse(Console.ReadLine());
            gender = (Gender)index;

            Console.WriteLine($"My name is {name} and I'm {gender} in gender.");
            */

            Console.WriteLine("0 Male, 1 Female, 2 Other");
            Console.Write("Your Gender: ");
            int index = int.Parse(Console.ReadLine());
            Gender gender = (Gender)index;

            switch (gender)
            {
                case Gender.Male:
                    Console.WriteLine("You are a male!");
                    break;
                case Gender.Female:
                    Console.WriteLine("You are a female!");
                    break;
                case Gender.Other:
                    Console.WriteLine("You are other!");
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;

            }

        }

        enum Gender { Male, Female, Other }

        static string ReturnMethod(int a, int b)
        {
            return $"Result: {a + b}";
        }

        static void Demo(dynamic name)
        {
            Console.WriteLine(name);
            Console.WriteLine(name.GetType());
        }

        static void MyArrayMethod(params int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] += 2;
            }

            foreach (var number in myArray)
            {
                Console.WriteLine(number);
            }
        }


        static void PassByValue(int myValue)
        {
            myValue += 5;
            Console.WriteLine($"MyValue: {myValue}");
        }

        static void PassByReference(ref int myValue)
        {
            myValue += 5;
            Console.WriteLine($"MyValue: {myValue}");
        }

        static void PassByOut(out int myValue)
        {
            myValue = 10;
            Console.WriteLine($"MyValue: {myValue}");
        }

        static void MyMethod(string message, int length = 2)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}

/*
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

            string message = (2 < 4) ? "Valid message" : "Invalid message";
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
*/

/*
namespace CSharpBasics
{
    public class MyApp
    {
        public static void Main()
        {
            string firstName = "          Ammar         ";
            firstName = firstName.Trim();
            string lastName = "Abid";

            string name = $"My name is {firstName} {lastName}";
            Console.WriteLine(name.Replace("Ammar", "Ali Haider"));

            name = name.ToUpper();
            Console.WriteLine(name.Contains("ABID"));
            Console.WriteLine(name.Length);

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            int a = 2100000000;
            int b = 2100000000;
            long c = (long)a + (long)b;
            Console.WriteLine(c);

            double a1 = 42.1;  // Natural Type
            float b1 = 38.2F;
            double c1 = a1 + b1;

            decimal a2 = 42.1M;   // Explicit Type
            decimal b2 = 38.2M;
            decimal c2 = a2 + b2;
            Console.WriteLine(c);

            decimal min = Decimal.MinValue;
            decimal max = Decimal.MaxValue;
            Console.WriteLine($"The range of decimal is from {min} to {max}");

            int a3 = 5;
            int b3 = 6;
            int c3 = a3 + b3;
            bool myTest = c > 10;
            if (a + b > 10)
            {
                Console.WriteLine("Greater than 10.");
            }
            else
            {
                Console.WriteLine("Less than 10.");
            }

            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter < 5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }


            // array[string]
            // arrays are fixed in length! can't add or remove anything from array
            var names = new string[]
            {
                "Ali",
                "Ammar",
                "Abid",
            };
            // make new array to add some thing
            names = [.. names, "David"];

            foreach (var n in names) // Index 2 included but 5 is not  
            {
                Console.WriteLine(n.ToUpper());
            }



            // List<string>
            var names1 = new List<string>
            {
                "Ali",
                "Ammar",
                "Abid",
            };
            names1.Add("Scott");
            names1.Add("David");
            Console.WriteLine(names[^1]);  // last item in list
            foreach (var n1 in names1[2..5]) // from index 2 to 4 (5 is exclusive) 
            {
                Console.WriteLine(n1.ToUpper());
            }



            var numbers = new List<int> { 43, 12, 34, 86, 65 };
            Console.WriteLine($"I found 34 at index {numbers.IndexOf(34)}");
            numbers.Sort();
            Console.WriteLine($"I found 34 at index {numbers.IndexOf(34)}");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }



            // ------ Language Integrated Query -------

            List<int> scores = [3, 45, 82, 97, 92, 100, 81, 60];

            // query expression
            IEnumerable<int> scoresQuery = from score in scores
                                           where score > 80
                                           orderby score descending
                                           select score;
            int scoresCount = scoresQuery.Count();

            // method expression
            var scoresQuery2 = scores.Where(s => s > 80).OrderByDescending(s => s);

            List<int> myScores = [.. scoresQuery];

            // execute the query
            foreach (var score in myScores)
            {
                Console.WriteLine(score);
            }


        }
    }
}
*/
