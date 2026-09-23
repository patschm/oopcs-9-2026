namespace RadioStation;

internal class Program
{
    static void Main(string[] args)
    {
        Radio r538 = new Radio();
        r538.Message += OntvangstMethodes.ViaKabel;
        r538.Message += OntvangstMethodes.ViaPostduif;
        r538.Message += OntvangstMethodes.ViaMobiel;
        r538.Message += OntvangstMethodes.ViaEther;
        r538.Message += OntvangstMethodes.ViaInternet;
        r538.Message += OntvangstMethodes.ViaTv;
        r538.Message += OntvangstMethodes.ViaPostduif;
        r538.Message += OntvangstMethodes.ViaKabel;
        r538.Message += OntvangstMethodes.ViaPostduif;
        r538.Message += OntvangstMethodes.ViaMobiel;
        r538.Message += OntvangstMethodes.ViaEther;
        r538.Message += OntvangstMethodes.ViaInternet;
        r538.Message += OntvangstMethodes.ViaTv;
        r538.Message += OntvangstMethodes.ViaPostduif;

       // r538.subscribers("Heya klojo's");

        r538.ZendUit();

    }
}
