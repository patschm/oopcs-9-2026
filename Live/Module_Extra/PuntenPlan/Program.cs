namespace PuntenPlan;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 10, Y = 20 };

        Console.WriteLine(p1);
        Point ppp = p1;
        DoeIets(p1);
        Console.WriteLine(p1);

        string x = "Hoi";
        Console.WriteLine(x);
        DoeIets(ref x);
        Console.WriteLine(x);
    }

    private static void DoeIets(Point ppp)
    {
        ppp = new Point
        {
            X = 1000,
            Y = 2000
        };
    }

    static void DoeIets(ref string s)
    {
        s += "!!!!!";
    }
}
