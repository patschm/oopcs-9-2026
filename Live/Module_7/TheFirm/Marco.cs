using System;
using System.Collections.Generic;
using System.Text;

namespace TheFirm;

internal class Marco : Medewerker
{
    public void DoetIets()
    {
        Console.WriteLine("Marco doet iets");
    }

    public override void Werkt()
    {
        DoetIets();
    }
}
