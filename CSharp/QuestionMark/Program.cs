using System;

namespace QuestionMark
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = 0.1;
            //double b = 0.2;
            //Console.WriteLine(a+b==0.3? "true" : "false");

            //decimal c = 0.1M;
            //decimal d = 0.2M;
            //Console.WriteLine(c + d == 0.3M? "true" : "false");

            //// ?: => ternary operator

            //// ? nullable value type
            ///
            string? fullName = null;
            //int i = null;

            //C# cũ
            //Nullable<int> i = null;

            //C# mới
            bool? check = null;

            //int? length = fullName is null? 0 : fullName.Length;


            //null-conditinal operator ? tương tự !=, fullName khác null trả về vế sau.
            int? length = fullName?.Length;


            //null-coalescing operator ?? tương tự như dấu ==
            int? chieudai = fullName?.Length ?? 0;
        }
    }
}
