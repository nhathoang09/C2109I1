using System;
using System.Collections.Generic;
using System.Text;

namespace OopEncapsulation
{
    class SunFlower
    {
        static void Main(string[] args)
        {
            var pl = new Plant();
            pl.Public();
            pl.Internal();
            pl.ProtectedInternal();
        }
    }
}
