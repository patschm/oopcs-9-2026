using System;
using System.Collections.Generic;
using System.Text;

namespace TheFirm;

internal class Yaman : Medewerker
{
    public void BrengtNieuwBloedIn()
    {
        Console.WriteLine("Yaman brengt nieuw bloed in de company");
    }

    public override void Werkt()
    {
        BrengtNieuwBloedIn();
    }
}
