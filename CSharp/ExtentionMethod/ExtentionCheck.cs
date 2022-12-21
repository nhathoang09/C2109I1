using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethod
{
    //Biến class này thành extention method
    //=> class buộc phải là static
    //1 class là static thì toàn bộ bên trong nó phải là static
    static class ExtentionCheck
    {
        public static void IsGreaterThan(this int i, int value) => Console.WriteLine(i>value?true:false);

        public static void Hi(this Program obj) => Console.WriteLine("ahihi");
    }
}
