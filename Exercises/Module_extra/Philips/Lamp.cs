using Protocollen;

namespace Philips;

public class Lamp: IDetect
{
    public void Aan()
    {
        Console.WriteLine("De lamp gaat aan");
    }

    public void Activate()
    {
        Aan();
    }
}
