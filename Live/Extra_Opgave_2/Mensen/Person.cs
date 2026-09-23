using System;
using System.Collections.Generic;
using System.Text;

namespace Mensen;

internal class Person
{
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Firstname} {Lastname} ({Age})";
    }
}
