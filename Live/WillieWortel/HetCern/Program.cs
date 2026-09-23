namespace HetCern;

internal class Program
{
    static void Main(string[] args)
    {
        var willem = new WillemKlein();
        var simon = new SimonVanDerMeer();

        //willem.Reken(simon.Add, 4, 5);
        //willem.Reken(simon.Subtract, 6, 7);

        Berekening b1 = simon.Add;
        b1 = b1 + simon.Add;
        b1 = b1 + simon.Subtract;
        b1 = b1 - simon.Add;
        b1 += simon.Add;
        b1 += simon.Subtract;

        foreach (var b in b1.GetInvocationList())
        {
            Console.WriteLine(b.Method.Name);
        }

        int result = b1(1, 2);
        Console.WriteLine(result);
    }
}
