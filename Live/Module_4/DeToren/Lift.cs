namespace DeToren;

internal class Lift
{
    private int _currentFloor = 0;

    public void Call(int floor)
    {
        Console.WriteLine($"Met 65km/u naar de {floor}e verdieping");
        _currentFloor = floor;
        Task.Delay(1000).Wait();
        Console.WriteLine("We zijn er");
    }
    public int Status
    {
        get
        { 
            return _currentFloor; 
        }
    }
}