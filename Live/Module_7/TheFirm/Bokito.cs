using System;
using System.Collections.Generic;
using System.Text;

namespace TheFirm;

// Bokito IMPLEMENTEERT (DUS NIET!!!!!!! ERFT) de interface IContact
// 
internal class Bokito : IContract, IZooContract
{
    // Expliciete implementatie.
    void IZooContract.Produceert()
    {
        Console.WriteLine("Bokito produceert herrie");
    }
    public void Produceert()
    {
        Werkt();
    }

    public  void Werkt()
    {
        Console.WriteLine("Bokito ram secretaresses in elkaar");
    }
}
