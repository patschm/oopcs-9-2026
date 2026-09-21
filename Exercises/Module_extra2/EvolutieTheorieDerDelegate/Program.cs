namespace EvolutieTheorieDerDelegate;

delegate int MathDel(int a, int b);

internal class Program
{
    static void Main(string[] args)
    {
        // 2002/2003. .NET 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(1, 2);

        // 2005.  .NET 2
        MathDel m2 = Add;
        result = m2( 2, 3);

        int c = 100;

        MathDel m3 = delegate (int a, int b)
        {
            return a + b + c;
        };

        result = m3(3, 4);

        // 2007.  .NET3.0. De Lambda's
        MathDel m4 = (a, b) => a + b + c;
        result = m4(4, 5);

        // Procedures
        Action<string> a1 = Console.WriteLine;
        a1("hahaha");

        // Functions
        Func<string> f1 = Console.ReadLine;

        //a1(f1());

        Func<int, int, int> m5 = AddIntern;
        result = m5(5, 6);

        
        Console.WriteLine(result);

        int AddIntern(int a, int b)
        {
            return a + b + c;
        }

    }


    static int Add(int a, int b)
    {
        return a + b;
    }
}
