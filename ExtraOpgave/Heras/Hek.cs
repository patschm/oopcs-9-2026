using Standaarden;

namespace Heras;

public class Hek: IDetectable
{
    public void Detect()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("Hek is open.");
    }
}
