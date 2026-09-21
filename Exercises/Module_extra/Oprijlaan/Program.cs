using Canon;
using DoomsdayPreppers;
using Heras;
using Philips;
using Yunex;

namespace Oprijlaan;

class Program
{
    static void Main(string[] args)
    {
        var detectielus = new Detectielus();
        var hek = new Hek();
        var valkuil = new Valkuil();
        var lamp = new Lamp();
        var camera = new Camera();

        detectielus.Connect(hek);
        detectielus.Connect(valkuil);
        detectielus.Connect(lamp);
        detectielus.Connect(camera);

        detectielus.Connect(hek.Open);
        detectielus.Connect(valkuil.Open);
        detectielus.Connect(lamp.Aan);
        detectielus.Connect(camera.Start);

        detectielus.Detect += hek.Open;
        detectielus.Detect += valkuil.Open;
        detectielus.Detect += lamp.Aan;
        detectielus.Detect += camera.Start;



        detectielus.HmmmWatZienIkDaar();
        
    }
}
