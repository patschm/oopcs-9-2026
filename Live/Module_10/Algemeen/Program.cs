namespace Algemeen;

record Price(double Val);

internal class Program
{
    static void Main(string[] args)
    {
        Point<Action> p1 = new Point<Action>();

        Price a = new Price( 10);
        Price b = new Price(20);

        Console.WriteLine($"a={a}, b={b}");
        Swap<Price>(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
    }

    //private static void Swap(ref int aa, ref int bb)
    //{
    //    int tmp = aa;
    //    aa = bb; 
    //    bb = tmp;
    //}
    //private static void Swap(ref double aa, ref double bb)
    //{
    //    double tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swap(ref decimal aa, ref decimal bb)
    //{
    //    decimal tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    private static void Swap<T>(ref T aa, ref T bb)
    {
        T tmp = aa;
        aa = bb;
        bb = tmp;
    }
}

class Point<T> //where T:  IFormattable
{
    public T X { get; set; }
    public T Y { get; set; }
}





