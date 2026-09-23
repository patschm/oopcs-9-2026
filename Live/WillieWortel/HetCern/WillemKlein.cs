using System;
using System.Collections.Generic;
using System.Text;

namespace HetCern;

delegate int Berekening(int x, int y);

internal class WillemKlein
{
    public void Reken(Berekening cal, int a, int b)
    {
        Console.WriteLine("Willem Klein gaat nu rekenen....");
        int antwoord = cal(a,b);

        Console.WriteLine($"Willem kraait: Het antwoord is {antwoord}");
    }
}
