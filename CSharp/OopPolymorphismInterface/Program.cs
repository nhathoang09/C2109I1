using System;

namespace OopPolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new FileOne();
            f.WriteBinaryFile();
            f.WriteTextFile();
            f.ReadFile();
            ((IBinaryFile)f).ShowInfo();// Cũ
            (f as IBinaryFile).ShowInfo();// Mới
        }
    }
}
