using System;

namespace OopPolymorphismOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            var ch1 = new Child();
            ch1.Display();
            ch1.Show();

            Parent par = new Parent();
            par.Display();

            Parent pa = new Child();
            pa.Display();
            pa.Show();
        }
    }
}
