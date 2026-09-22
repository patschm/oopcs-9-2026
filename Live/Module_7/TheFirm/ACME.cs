namespace TheFirm;


// De interface is bedoelt om interactie tussen objecte te onkoppelen
// We spreken hiet ook van een CAN-DO.
// Degene die het gedrag van de interface aanroept, defineert meestal ook interface (producer)
// De implemtators noemen we dan de consumers
interface IContract
{
    void Produceert();
}

internal class ACME
{
    private List<IContract> employees = new();

    public void Hire(IContract medewerker)
    {
        employees.Add(medewerker);
    }

    public void Start()
    {
        Console.Beep(8000, 1000);
        Console.WriteLine("ACME begint te produceren");
        foreach (var employee in employees)
        {
            employee.Produceert();
        }
    }
}
