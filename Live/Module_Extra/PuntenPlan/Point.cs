namespace PuntenPlan;

internal class Point
{
    public int X { get; internal set; }
    public int Y { get; internal set; }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}