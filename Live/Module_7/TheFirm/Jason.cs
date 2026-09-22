using System;
using System.Collections.Generic;
using System.Text;

namespace TheFirm;

internal class Jason : Medewerker
{
    public void Compileert()
    {
        Console.WriteLine("Jason compileert er op los");
    }

    public override void Werkt()
    {
        Compileert();
    }
}
