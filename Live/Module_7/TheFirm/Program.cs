namespace TheFirm;

internal class Program
{
    static void Main(string[] args)
    {
        ACME company = new();
        Marco marco = new();
        Jason jason = new();
        Yaman yaman = new();
        Bokito bok = new();

        company.Hire(marco);
        company.Hire(jason);
        company.Hire(yaman);
        company.Hire(bok);
        company.Start();

        BleiDorp zoo = new();
        zoo.dier = bok;
        zoo.Open();
    }

}



