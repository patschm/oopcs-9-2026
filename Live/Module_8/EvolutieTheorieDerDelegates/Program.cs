namespace EvolutieTheorieDerDelegates;

delegate int MathDel(int a, int b);

internal class Program
{
    static void Main(string[] args)
    {
        // 2002. Framework 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(1,2);

        // 2005. Framework 2.0
        MathDel m2 = Add;
        result = m2(2,3);


        int c = 100;
        MathDel m3 = delegate (int a, int b)
        {
            return a + b + c;
        };
        result = m3(3,4);

        // 2007/2008 Framework 3.0/3.5
        MathDel m4 = (a, b) => a + b + c;
        result = m4(4, 5);

        // Procedures
        Action<string> a1 = Console.WriteLine;

        a1("Hallo");

        // Functions
        Func<int, int, int> m5 = Add;
        result = m5(5, 6);


        Func<int, int, int> m6 = (a, b) => a + b + c;
        result = m6(6, 7);
      
        Console.WriteLine(result);

       int LocalAdd(int a, int b)
      {
            return a + b + c;
        }
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
