using Standaarden;
namespace Yunex;

public class DetectieLus
{
    private List<IDetectable> devices = new List<IDetectable>();
    private List<Detectable> _devices = new List<Detectable>();
    public event  Detectable Detect;


    public void Connect(Detectable detectable)
    {
        _devices.Add(detectable);
    }
    public void Connect(IDetectable device)
    {
        devices.Add(device);
    }
    public void Detecteer()
    {
        Console.WriteLine("Detectielus ziet iets");
        // Interfaces
        foreach (var device in devices)
        {
            device.Detect();
        }
        // Delegates
        foreach (var device in _devices)
        {
            try
            {
                device();
            }
            catch (Exception ee) {
                Console.WriteLine(ee.Message);
            }
        }
        try
        {
            // Event
            Detect();
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message); 
        }
    }
}
