namespace Dagen
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int dag = 3;

            WeekDagen day = WeekDagen.Dinsdag;
            Console.WriteLine((int)day);

            WeekDagen day2 = Enum.Parse<WeekDagen>("Maandag");
            Console.WriteLine(day2);

            WeekDagen day3 = (WeekDagen)4;
            Console.WriteLine(day3);

            Price price = new Price(4.95);
            //price.p = 5.95;
            Lengte lengte = new Lengte(price.p);

        }

    }

    record Price(double p);
    record Lengte(double l);

    enum WeekDagen
    {
        Zondag = 1,
        Maandag,
        Dinsdag,
        Woensdag,
        Donderdag,
        Vrijdag,
        Zaterdag
    }

    enum Vlaggen : long
    { 
        Mask = 0,
        Mask1 = 1,
        Mask2 = 2,
        Mask3 = 4,
        Mask4 = 8
    }

}


