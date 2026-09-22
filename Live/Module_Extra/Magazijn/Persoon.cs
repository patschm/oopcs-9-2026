namespace Afas;

public class Persoon
{
	private int _age;

	public int Age
	{
		get { return _age; }
		set { _age = value; }
	}
	public string? Firstname { get; set; }
    public string? Lastname { get; set; }
	protected internal string? Hobby { get; set; } = "Sigarenbandjes sparen";


	public void Introduce()
	{
        Console.WriteLine($"Hi, ik ben {Firstname} {Lastname} ({Age})");
	}
}
