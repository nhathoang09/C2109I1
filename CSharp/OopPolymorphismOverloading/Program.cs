using System;

namespace OopPolymorphismOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var math1 = new BasicMath();
            var math2 = new BasicMath()
            {
                NumberOne = 5,
                NumberTwo = 6
            };
            var math3 = new BasicMath()
            {
                NumberTwo = 7
            };
        }
    }
}
