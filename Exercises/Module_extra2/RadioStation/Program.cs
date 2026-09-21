namespace RadioStation;

internal class Program
{
    static void Main(string[] args)
    {
        RadioStation r538 = new RadioStation();
        r538.Subscribers += ViaMail;
        r538.Subscribers += ViaKabel;
        r538.Subscribers += ViaPostduif;
        r538.Subscribers += ViaRooksignalen;
        r538.Subscribers += ViaSMS;
        r538.Subscribers += ViaMail;
        r538.Subscribers += ViaKabel;
        r538.Subscribers += ViaPostduif;
        r538.Subscribers += ViaRooksignalen;
        r538.Subscribers += ViaSMS;
        r538.Subscribers += ViaMail;
        r538.Subscribers += ViaKabel;
        r538.Subscribers += ViaPostduif;
        r538.Subscribers += ViaRooksignalen;
        r538.Subscribers += ViaSMS;


        r538.Broadcast();

        //r538.Subscribers("Hello Suckers!!!");

    }


    static void ViaMail(string message)
    {
        Console.WriteLine($"Via mail ontvangen: {message}");
    }
    static void ViaKabel(string message)
    {
        Console.WriteLine($"Via kabel ontvangen: {message}");
    }
    static void ViaSMS(string message)
    {
        Console.WriteLine($"Via sms ontvangen: {message}");
    }
    static void ViaRooksignalen(string message)
    {
        Console.WriteLine($"Via rooksignalen ontvangen: {message}");
    }
    static void ViaPostduif(string message)
    {
        Console.WriteLine($"Via Postduif ontvangen: {message}");
    }
}
