using Afas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Afas;

public class BordSpeler : Persoon
{
    public void Speel()
    {
        Hobby = "Bordspelen";
        Console.WriteLine($"{Firstname} speelt nu Istanbul");
    }
}
