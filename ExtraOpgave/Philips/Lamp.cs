using Standaarden;

namespace Philips;

public class Lamp : IDetectable
{
    public void Detect()
    {
        TurnOn();
    }

    public void TurnOn()
{
    Console.WriteLine("Lamp is aan.");
    
}
}