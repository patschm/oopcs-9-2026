using System;
using System.Collections.Generic;
using System.Text;

namespace Lampen;

abstract class Lamp
{
    protected int branduren = 3000;
    private int _intensiteit = 100;
    public ConsoleColor Kleur { get; set; } = ConsoleColor.DarkCyan;
    public int Intensiteit
    {
        get { return _intensiteit; }
        set
        {
            if (value >= 0 && value < 1000)
            {
                _intensiteit = value;
            }
            else
            {
                Console.WriteLine("Kannie");
            }
        }
    }

    // Met virtual geef ik aan dat dit gedrag polymorf-ready (override is optioneel)
    public virtual void Aan()
    {
        if (branduren <= 0)
        {
            Console.WriteLine("Koopt u maar een nieuwe");
            return;
        }

        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp is aan en brandt met {Intensiteit}lumen");
    }
    // Met abstract is het overriden verplicht.
    public abstract void Uit();
    //{
    //    Console.ResetColor();
    //    Console.WriteLine("De lamp is uit");
    //}
}
