using System;
using System.Collections.Generic;
using System.Text;

namespace RadioStation;

delegate void SubscriptionMethod(string msg);

internal class RadioStation
{
    public event SubscriptionMethod Subscribers;

    //public event SubscriptionMethod Subscribers
    //{
    //    add
    //    {
    //        subscribers += value;
    //    }
    //    remove
    //    {
    //        subscribers -= value;
    //    }
    //}

    public void Broadcast()
    {
        Console.WriteLine("We are on air");
        Subscribers("Goooooooeeeie morgen luisteraars");
    }
}
