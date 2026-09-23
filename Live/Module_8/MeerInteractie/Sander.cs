using System;
using System.Collections.Generic;
using System.Text;

namespace MeerInteractie;

// Weer een nieuw type.
// Een blauwdruk van een functie
delegate void Opdracht();

internal class Sander
{
    public void VoerUit(Opdracht func)
    {
        Console.WriteLine("Sander voert uit");
        func();
    }
}
