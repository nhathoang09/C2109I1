using System;
using System.Collections.Generic;
using System.Text;

namespace OopAbstraction
{
    abstract class Cat : Animal
    {
        private bool gender;
        
        public void ShowInfCat()
        {
            Console.WriteLine($"{nameof(gender)} = {gender}");
        }
    }
}
