using System;
using System.Collections.Generic;
using System.Text;

namespace RadioStation;

delegate void Transport(string msg);

internal class Radio
{
    private Transport _subscribers;

    public event Transport Message
    {
        add
        {
            _subscribers += value;
        }
        remove
        {
            _subscribers -= value;
        }
    }

    //public event Transport Subscribers;

    public void ZendUit()
    {
        Console.WriteLine("We gaan uitzenden");
        if (_subscribers != null) {
            _subscribers("Hallo luisteraars");
        }
    }
}
