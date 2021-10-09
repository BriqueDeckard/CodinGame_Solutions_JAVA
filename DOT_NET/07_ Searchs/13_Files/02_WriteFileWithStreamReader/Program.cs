using System;
using System.IO;

namespace _02_WriteFileWithStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object of FIleInfo for the specified path
            FileInfo fI =
                new FileInfo(@"E:\GIT\Notes\DOT_NET\07_ Searchs\13_Files\02_WriteFileWithStreamReader\DummyFile.txt");

            // Open file for Read\Write
            FileStream fS =
                fI
                    .Open(FileMode.OpenOrCreate,
                    FileAccess.Write,
                    FileShare.Read);

            // Create StreamWriter to write string to FileSTreal
            StreamWriter sW = new StreamWriter(fS);
            sW.WriteLine("Hello World\n");
            sW.WriteLine("===========\n");
            sW.Close();
        }
    }
}
