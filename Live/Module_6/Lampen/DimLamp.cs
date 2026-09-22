namespace Lampen;

// DimLamp Erft van Lamp
// Bevordert hergebruik
// GEBRUIK OVERERVING ALLEEN ALS HET EEN IS-EEN RELATIE IS.
sealed class DimLamp : Lamp
{
    public void DimUp(int newIntens)
    {
        Intensiteit = newIntens;
        Console.WriteLine($"De dimlamp is aan en brandt met {Intensiteit}lumen");
    }
    public sealed override void Aan()
    {
        Intensiteit = 10;
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De dimlamp is aan en brandt met {Intensiteit}lumen");
    }
    public override void Uit()
    {
        Console.ResetColor();
        Console.WriteLine("De dimlamp is uit");
    }
}
