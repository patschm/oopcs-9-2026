using Protocollen;

namespace Yunex;

public delegate void Activator();
public delegate void Activator1(int x);

public class Detectielus
{
    private List<IDetect> _devices = new List<IDetect>();
    private List<Activator> _activators = new List<Activator>();
    public event Activator Detect;
    

    public void Connect(IDetect device)
    {
        _devices.Add(device);
    }
    public void Connect(Activator device)
    {
        _activators.Add(device);
    }
    public void HmmmWatZienIkDaar()
    {
        Console.WriteLine("De detectielus detecteert iets");
        foreach (var device in _devices) 
        {
            device.Activate();
        }
        Console.WriteLine(new string('=', 80));
        foreach (var device in _activators)
        {
            device();
        }
        Console.WriteLine(new string('=', 80));
        Detect?.Invoke();

    }
}
