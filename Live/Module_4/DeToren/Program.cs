namespace DeToren;

internal class Program
{
    static void Main(string[] args)
    {
        string s = "hoi";
        var v =  s.SponsoredBy("ACME");
        Console.WriteLine(v);

        Point p1 = new Point { X=10, Y=20 };
        Point p2 = new Point { X=100, Y=200 };

        Point pres = p1 + p2;

        Console.WriteLine(pres);

  

        return;


        //Etage.ToonLiftPositie();
        //Etage._elevator.Call(300);

        Etage[] flat = new Etage[120];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage { EtageNummer = i };
        }


        flat[67].RoepLift();

        foreach(Etage et in flat)
        {
            et.ToonLiftPositie();
        }
    }
}
