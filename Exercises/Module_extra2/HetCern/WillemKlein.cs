using System;
using System.Collections.Generic;
using System.Text;

namespace HetCern;

delegate int MathDel(int x, int y);

internal class WillemKlein
{
    public void Bereken(MathDel calc, int a, int b)
    {
        Console.WriteLine("Willem gaat nu rekenen...");
        int result = calc(a,b);

        Console.WriteLine($"Willem kraait: Het resultaat = {result}");
    }

}
