using System;
using System.IO;

namespace _01_ReadFileWithStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of FileInfo for specified path
            FileInfo fi =
                new FileInfo(@"E:\GIT\Notes\DOT_NET\07_ Searchs\01_Areas\01_AreaDisk\Program.cs");

            //Open a file for Read\Write
            FileStream fs =
                fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            //Create an object of StreamReader by passing FileStream object on which it needs to operates on
            StreamReader sr = new StreamReader(fs);

            //Use the ReadToEnd method to read all the content from file
            string fileContent = sr.ReadToEnd();

            Console.WriteLine (fileContent);

            //Close the StreamReader object after operation
            sr.Close();
            fs.Close();
        }
    }
}
