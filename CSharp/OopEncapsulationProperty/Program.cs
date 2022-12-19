using System;

namespace OopEncapsulationProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new HumanBeing();
            human.FullName = "Nhat Hoang";
            human.Address = "123 abc";
        }
    }
}
