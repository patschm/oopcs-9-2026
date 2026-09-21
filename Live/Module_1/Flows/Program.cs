using System.Threading.Channels;

namespace Flows;

internal class Program
{
    static void Main(string[] args)
    {
        int age = 34;
        if(age < 18)
        {

        }
        else if (age > 67)
        {

        }
        else
        {

        }

        switch (age)
        {
            case 0:
            case 1:
                Console.WriteLine("een");
                break;
            case 2:
                Console.WriteLine("twee");
                break;
            case > 20:
                Console.WriteLine("Ouder dan 20");
                break;

            case int xx when xx > 30 && xx < 40:
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Iets anders");
                break;
        }

        int x = 0;
        // Als je exact weet hoe vaak je iets moet doen
        for (Console.WriteLine("Init"); x < 10 ; Console.WriteLine("it"))
        {
            if (++x == 5) continue;
            Console.WriteLine(x);
        }
        Console.WriteLine(x);

        // 0 of meer iteraties
        while(x < 25)
        {
           Console.WriteLine(x++);
        }

        // 1 of meer iteraties
        do
        {
            Console.WriteLine(x++);
        }
        while (x < 30);

    }


}
