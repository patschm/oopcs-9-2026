using Bogus;

namespace Mensen;

class PerProj
{
    public string First { get; set; }
    public int Age { get; set; }
}

internal class Program
{
    static void Main(string[] args)
    {
        var people = CreatePeople();
        var peeps = people.OrderBy(OrderByAge);

        Console.WriteLine("Met welke letter moet de voornaam beginnen?");
        string letter = Console.ReadLine().ToUpper();

        var ppps = people
            .Where(p => p.Firstname.StartsWith(letter))
            .OrderBy(p => p.Lastname)
            .Select(p => new  { Age = p.Age, First = p.Firstname });
    
        //foreach (var p in ppps)
        //{
        //    Console.WriteLine(p);
        //}
        foreach(var pp in ppps)
        {
            Console.WriteLine($"{pp.First} ({pp.Age})");
        }
    }

    static bool NameStartWithB(Person p)
    {
        return p.Firstname.StartsWith("B");
    }
    static bool NameStartWithA(Person p)
    {
        return p.Firstname.StartsWith("A");
    }
    static int OrderByAge(Person p)
    {
        return p.Age;
    }
    static string OrderByLastName(Person p)
    {
        return p.Lastname;
    }

    static List<Person> CreatePeople(int hoeveeldan = 100)
    {
        //var ff = new Faker();
    
        return new Bogus.Faker<Person>()
            .RuleFor(p => p.Firstname, f => f.Name.FirstName())
            .RuleFor(p => p.Lastname, f => f.Name.LastName())
            .RuleFor(p => p.Age, f => f.Random.Int(0, 123))
            .Generate(hoeveeldan)
            .ToList();
    }
}





