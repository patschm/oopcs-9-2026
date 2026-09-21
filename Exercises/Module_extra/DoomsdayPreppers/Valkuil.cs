using Protocollen;

namespace DoomsdayPreppers;

public class Valkuil:IDetect
{
    public void Activate()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("De valkuil met scherpe spiezen opent");
    }
}
