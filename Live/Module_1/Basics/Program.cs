namespace Basics;
// Nee
internal class Program
{
    // Nee
    static void Main(string[] args)
    {
        // TypeNaam varnaam;

        //short
        int age = 10;
        age = age + 1;
        Console.WriteLine(++age);
        var x = 3 + 5 * 2;
        {
            string name = "Jan";
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
        //Console.WriteLine(name);
        var price = 20.1M;

        //List<Dictionary<string, Func<int>>> t1

        double y = 4 / 6;

        Console.WriteLine(y);

        Console.WriteLine(price);
        bool b1 = false & Test("");
        Console.WriteLine(b1);

        int a1 = 1; // 0001
        int a2 = 2; // 0010
        Console.WriteLine(a1 & a2);

        int? d = null;

        Console.WriteLine(d ?? 42);

        string? first = null;
        Test(first);
        Console.WriteLine(first?.Length);
    }

    static bool Test(string? s )
    {
        Console.WriteLine(s.Length);
        return false;
    }
}
