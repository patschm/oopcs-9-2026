using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DeToren;

internal class Etage
{
    // De lift wordt nu gedeeld door alle etage objecten.
    // Geen etage object kan zeggen "Die lift is van mij"
    // Dergelijke members worden ook wel class members genoemd.
    public static Lift _elevator = new Lift();
    // Etagenummer wordt daarentegen een instance member genoemd
    public int EtageNummer { get; set; } = 0;


    public void RoepLift()
    {
        Etage._elevator.Call(this.EtageNummer);
    }
    public void ToonLiftPositie()
    {
        Console.WriteLine($"De lift staat nu op de {_elevator.Status}e verdieping");
    }

    static Etage()
    {
        Console.WriteLine("De lift wordt aangemaakt");
    }






}
