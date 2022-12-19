using System;
using System.Collections.Generic;
using System.Text;

namespace OopPolymorphismOverride
{
    class Child:Parent
    {
        public override void Display()
        {
            //base.Display();
            Console.WriteLine("Child display");
        }

        public new void Show()
        {
            Console.WriteLine("Child show");
        }
    }
}
