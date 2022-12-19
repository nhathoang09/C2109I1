using System;
using System.Collections.Generic;
using System.Text;

namespace OopPolymorphismInterface
{
    interface IBinaryFile
    {
        //Có kiểu trả về và tên các phương thức nhưng không có bổ từ
        void WriteBinaryFile();
        void ReadFile();

        //Phương thức mặc định của Interface
        void ShowInfo() => Console.WriteLine("This is binary file");
    }
}
