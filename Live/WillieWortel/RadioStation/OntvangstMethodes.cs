using System;
using System.Collections.Generic;
using System.Text;

namespace RadioStation;

internal class OntvangstMethodes
{
    public static void ViaMobiel(string msg)
    {
        Console.WriteLine($"Via Mobiel ontvangen: {msg}");
    }
    public static void ViaEther(string msg)
    {
        Console.WriteLine($"Via Ether ontvangen: {msg}");
    }
    public static void ViaKabel(string msg)
    {
        Console.WriteLine($"Via Kabel ontvangen: {msg}");
    }
    public static void ViaInternet(string msg)
    {
        Console.WriteLine($"Via Internet ontvangen: {msg}");
    }
    public static void ViaPostduif(string msg)
    {
        Console.WriteLine($"Via Postduif ontvangen: {msg}");
    }
    public static void ViaTv(string msg)
    {
        Console.WriteLine($"Via TV ontvangen: {msg}");
    }
}










