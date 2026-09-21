namespace VirtualWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Big bang

            // l1 is het object (instantie van Lamp)
            Lamp l1 = new Lamp(200, ConsoleColor.Yellow);
            l1.Kleur = ConsoleColor.Yellow;
           // l1.SetIntensiteit(300);
            l1.Intensiteit = -400;
            //l1._intensiteit = -200;


            Lamp l2 = new Lamp { Intensiteit = 400, Kleur = ConsoleColor.Red };
            l1.Aan();

            l2.Aan();
            l2.Uit();
            l1.Uit();
            // Big crunch
        }
    }

    // Class Lamp is blauwdruk van een lamp
    class Lamp
    {
        // Fields
        // in fields slaan we eigenschappen op
        //private ConsoleColor _kleur = ConsoleColor.Yellow;
        private int _intensiteit = 100;

        // Constructors.
        // Constructors zijn bedoeld om FIELDS een initele waarde te geven.
        // Gebruik ze vooral als de gebruiker een initele MOET geven.
        public Lamp() : this(100, ConsoleColor.Yellow)
        {
            
        }
        public Lamp(int intensiteit, ConsoleColor kleur)
        {
            Intensiteit = intensiteit;
            Kleur = kleur;
        }

        // Auto generating property
        public ConsoleColor Kleur { get;  set; }


        // Properties.
        // Hiermee geven wij GECONTROLEERDE toegang to fields
        public int Intensiteit
        {
            get { return _intensiteit; }
            set
            {
                if (value >= 0 && value < 1000)
                {
                    _intensiteit = value;
                }
                else
                {
                    Console.WriteLine("Kannie");
                }
            }
        }

        //public void SetIntensiteit(int val)
        //{
        //    if (val >= 0 && val < 1000)
        //    {
        //        _intensiteit = val;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Kannie");
        //    }
        //}

        //public int GetIntensiteit()
        //{
        //    return _intensiteit;
        //}

        // Gedrag van een object leg je vast in methods.
        public void Aan()
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De lamp is aan en brandt met {Intensiteit}lumen");
        }
        public void Uit()
        {
            Console.ResetColor();
            Console.WriteLine("De lamp is uit");
        }
    }
}
