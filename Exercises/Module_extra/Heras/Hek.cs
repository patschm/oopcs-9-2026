using Protocollen;

namespace Heras;

public class Hek : IDetect
{
    public void Activate()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("Het hek gaat open");
    }
}
