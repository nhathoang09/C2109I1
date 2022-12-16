using System;

namespace ArgumentAndParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // khai bao doi tuong
            // bằng var 
            var argu = new ArgumentClass();

            // bằng target-type
            //ArgumentClass argu = new();

            //named argument
            argu.Display(4, 5, 6);
            argu.Display(a: 4, b: 5, c: 6);
            argu.Display(a: 4, 5, c: 6);
            argu.Display(c: 6, b: 5, a: 4);

            argu.Show(10,5);

            argu.SumParam(1, 2, 3, 4, 5);
            int[] mang = { 1, 2, 3, 4, 5, 6 };
            argu.SumParam(mang);
        }
    }
}
