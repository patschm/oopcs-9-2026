using System;
using System.Collections.Generic;
using System.Text;

namespace DeToren;

static class TypeExtension
{
    public static string SponsoredBy(this object x, string name)
    {
        return $"{x} is sponsored by {name}";
    }
}
