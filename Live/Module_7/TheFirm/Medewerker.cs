namespace TheFirm;

abstract class Medewerker : Persoon, IContract
{
    public void Produceert()
    {
        Werkt();
    }

    public abstract void Werkt();
    
}
