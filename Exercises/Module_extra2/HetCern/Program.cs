namespace HetCern;

class Program
{
    static void Main(string[] args)
    {
        WillemKlein willem = new WillemKlein();
        SimonVdMeer simon = new SimonVdMeer();

        
        //willem.Bereken(simon.Subtract, 2,3);


        MathDel m1 = simon.Add;
        m1 = m1 + simon.Subtract + simon.Add + simon.Subtract + simon.Add;
        m1 += simon.Subtract;

        foreach (var meth in m1.GetInvocationList())
        {
            Console.WriteLine($"{meth.Method.Name}");
        }


        int result = m1(1, 2);



        Console.WriteLine(result);
    }
}
