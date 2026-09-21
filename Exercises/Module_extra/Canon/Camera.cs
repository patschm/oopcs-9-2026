using Protocollen;

namespace Canon;

public class Camera : IDetect
{
    public void Activate()
    {
        Start();
    }

    public void Start()
    {
        Console.WriteLine("De camera start de opnames");
    }
}
