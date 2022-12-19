using System;
using System.Collections.Generic;
using System.Text;

namespace OopPolymorphismInterface
{
    class FileOne : IBinaryFile, ITextFile
    {
        public void ReadFile() => Console.WriteLine("Read File");

        public void WriteBinaryFile() => Console.WriteLine("Write Binary File");

        public void WriteTextFile() => Console.WriteLine("Write file");
    }
}
