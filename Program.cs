/*
using System;
namespace MyFirstConsoleApp
{
    public class MyApp
    {
        public static void Main()
        {
            Console.Write("hello");
        }
    }
}
*/

/*
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
*/

/*
int a = 2100000000;
int b = 2100000000;
long c = (long)a + (long)b;
Console.WriteLine(c);

double a = 42.1;  // Natural Type
float b = 38.2F;
double c = a + b;

decimal a = 42.1M;   // Explicit Type
decimal b = 38.2M;
decimal c = a + b;
Console.WriteLine(c);

decimal min = Decimal.MinValue;
decimal max = Decimal.MaxValue;
Console.WriteLine($"The range of decimal is from {min} to {max}");

int a = 5;
int b = 6;
int c = a + b;
bool myTest = c > 10;
if (a + b > 10)
{
    Console.WriteLine("Greater than 10.");
}
else
{
    Console.WriteLine("Less than 10.");
}
*/

/*
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
*/

/*
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

foreach (var name in names) // Index 2 included but 5 is not  
{
    Console.WriteLine(name.ToUpper());
}
*/

/*
// List<string>
var names = new List<string>
{
    "Ali",
    "Ammar",
    "Abid",
};
names.Add("Scott");
names.Add("David");
Console.WriteLine(names[^1]);  // last item in list
foreach (var name in names [2..5]) // from index 2 to 4 (5 is exclusive) 
{
    Console.WriteLine(name.ToUpper());
}
*/

/*
var numbers = new List<int> { 43, 12, 34, 86, 65 };
Console.WriteLine($"I found 34 at index {numbers.IndexOf(34)}");
numbers.Sort();
Console.WriteLine($"I found 34 at index {numbers.IndexOf(34)}");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}
*/

/*
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
*/

// ------- OOP ---------

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



