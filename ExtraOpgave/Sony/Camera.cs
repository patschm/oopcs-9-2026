using Standaarden;

namespace Sony;

public class Camera : IDetectable
{
    public void Detect()
    {
        Start();
    }

    public void Start()
{
    Console.WriteLine("Camera start de live streaming.");
}
}