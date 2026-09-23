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

        lus.Connect(hek);
        lus.Connect(valkuil);
        lus.Connect(lamp);
        lus.Connect(camera);     

        lus.Detect();
    }
    
}
