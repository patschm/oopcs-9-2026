namespace MeerInteractie;

internal class Program
{
    static void Main(string[] args)
    {
        var patrick = new Patrick();
        var sander = new Sander();

        sander.VoerUit(patrick.Instructie);
        sander.VoerUit(Ontplof);
        Opdracht opdr = Ontplof;

            
    }

    static void Ontplof()
    {
        Console.WriteLine("Kaboooom!!!");
    }
}
