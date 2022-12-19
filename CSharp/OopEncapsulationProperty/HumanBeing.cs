using System;
using System.Collections.Generic;
using System.Text;

namespace OopEncapsulationProperty
{
    internal class HumanBeing
    {
        //fields các field phải là private
        private string fullname;
        //thuộc tính address và age theo C# mới
        public string Address { get; set; }
        public int Age { get; set; }

        //property theo C# cũ (viết theo dạng mobile)
        public string FullName{ set => fullname = value; get => fullname;}

        public void ShowProper()
        {
            Console.WriteLine($"{nameof(fullname)} = {fullname}");
            Console.WriteLine($"{nameof(Address)} = {Address}");
        }
    }
}
