using System;
using System.Collections.Generic;
using System.Text;

namespace Lampen;

internal class TL : Lamp
{
    public int StartInterval { get; set; }
    // Met override ACTIVEER ik polymorfisme (Dit is niet verplicht)
    public override void Aan()
    {
        branduren -= 10;
        Console.BackgroundColor = Kleur;
        Console.WriteLine("De TL Knippert");
        Console.WriteLine($"De TL is aan en brandt met {Intensiteit}lumen");
    }
    public override void Uit()
    {
        Console.ResetColor();
        Console.WriteLine("De TL is uit");
    }
}
