namespace MethodsProcEtc;

internal class Program
{
    static void Main(string[] args)
    {
        ToonWelkom();
        int a = VraagOmGetal("A");
        int b = VraagOmGetal("B");
        int resultaat = DoeBerekening(a, b);
        ToonUitkomst(resultaat);
        ToonTotZiens();

        //resultaat.ToString();
    }

     static void ToonTotZiens()
    {
        Console.WriteLine("Tot ziens");
    }

     static void ToonUitkomst(int resultaat)
    {
        Console.WriteLine($"Het antwoord is {resultaat}");
    }

    // Type | void NaamFuncProc(Type p1, Type p2)
    // {
    // }

    static void ToonWelkom()
    {
        Console.WriteLine("Welkom wiskundige!");
    }
     
    static int VraagOmGetal(string val)
    {
        do
        {
            Console.Write($"Geef getal {val}: ");
            string snr = Console.ReadLine();
            //int nummer;
            if (IsValid(snr, out int nummer))
            {
                return nummer;
            }
            Console.WriteLine("Ongeldig. Probeer het nog eens");
        }
        while(true);
    }

    static bool IsValid(string? snr, out int getal)
    {
        //int getal;
        bool ok = int.TryParse(snr, out getal);
        Console.WriteLine(getal);
        return ok;
    }

    static int DoeBerekening(int a, int b)
    {
        return a + b;
    }
}









