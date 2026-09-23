using Standaarden;
namespace Yunex;

public class DetectieLus
{
    private List<IDetectable> devices = new List<IDetectable>();

    public void Connect(IDetectable device)
    {
        devices.Add(device);
    }
    public void Detect()
    {
        Console.WriteLine("Detectielus ziet iets");
        foreach (var device in devices)
        {
            device.Detect();
        }
    }
}
