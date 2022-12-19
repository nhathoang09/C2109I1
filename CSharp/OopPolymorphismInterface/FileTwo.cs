using System;
using System.Collections.Generic;
using System.Text;

namespace OopPolymorphismInterface
{
    class FileTwo : IBinaryFile, ITextFile
    {
        //Không dùng bổ từ
        void IBinaryFile.ReadFile() => Console.WriteLine("Read File");
        void ITextFile.ReadFile() => Console.WriteLine("Read File");

        //Bắt buộc dùng bổ từ
        public void WriteBinaryFile() => Console.WriteLine("Write Binary File");

        public void WriteTextFile() => Console.WriteLine("Write file");
    }
}
