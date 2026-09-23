using DoomsdayPreppers;
using Heras;
using Philips;
using Sony;
using Yunex;

namespace Oprijlaan;

class Program
{
    static void Main(string[] args)
    {
        var lus = new DetectieLus();
        var hek = new Hek();
        var lamp = new Lamp();
        var camera = new Camera();
        var valkuil = new Valkuil();

        // Interfaces
        //lus.Connect(hek);
        //lus.Connect(valkuil);
        //lus.Connect(lamp);
        //lus.Connect(camera);

        // Delegates
        lus.Connect(hek.Open);
        lus.Connect(valkuil.Open);
        lus.Connect(lamp.TurnOn);
        lus.Connect(camera.Start);

        // Events
        lus.Detect += hek.Open;
        lus.Detect += valkuil.Open;
        lus.Detect += lamp.TurnOn;
        lus.Detect += camera.Start;

        lus.Detecteer();
    }
    
}
