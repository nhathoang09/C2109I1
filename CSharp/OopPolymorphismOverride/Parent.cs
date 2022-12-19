using System;
using System.Collections.Generic;
using System.Text;

namespace OopPolymorphismOverride
{
    class Parent
    {
        public void Show() => Console.WriteLine("Parent show");
        public virtual void Display() => Console.WriteLine("Parent display");
    }
}
