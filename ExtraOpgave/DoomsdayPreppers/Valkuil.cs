using Standaarden;

namespace DoomsdayPreppers;

public class Valkuil: IDetectable
{
    public void Detect()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("Valkuil is open.");
        throw new Exception("Ooops");
    }
}
