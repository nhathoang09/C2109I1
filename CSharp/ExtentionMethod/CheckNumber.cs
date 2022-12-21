using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethod
{
    class CheckNumber
    {
        public static void Check(int i, int value)
        {
            if (i > value)
                {
                    Console.WriteLine($"{i} dung la lon hon {value}");
                }
        }
    }
}
