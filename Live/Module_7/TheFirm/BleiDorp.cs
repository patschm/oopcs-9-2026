using System;
using System.Collections.Generic;
using System.Text;

namespace TheFirm;

interface IZooContract
{
    void Produceert();
}

internal class BleiDorp
{
    public IZooContract dier;

    public void Open()
    {
        Console.WriteLine("De dierentuin gaat open");
        dier.Produceert();
    }
}
