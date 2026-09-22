namespace Lampen;

internal class Program
{
    static void Main(string[] args)
    {
        //Lamp l1 = new Lamp { Intensiteit = 200 };
        //l1.Aan();
        //l1.Uit();

        // Dit is generalisatie.
        Lamp l2 = new DimLamp { };
        l2.Aan();
        //l2.branduren = 10000;
        //l2.DimUp(120);

        Lamp l3 = new TL { Kleur = ConsoleColor.Red, Intensiteit = 200, StartInterval = 5 };
        if (l3 is TL)
            (l3 as TL)?.StartInterval = 6;

        l3.Aan();

    }

    static void ZetAan(Lamp dl)
    {
        dl.Aan();
    }
    //static void ZetAan(TL dl)
    //{
    //    dl.Aan();
    //}
}
