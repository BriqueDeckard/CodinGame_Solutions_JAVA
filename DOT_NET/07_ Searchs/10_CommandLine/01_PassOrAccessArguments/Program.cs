using System;

namespace _01_PassOrAccessArguments
{
    /// <summary>
    /// How to Pass or Access Command-line Arguments in C#?
    /// </summary>
    class Program
    {
        /*
        In C#, the Main() method is an entry point of the Console, Windows, or Web application (.NET Core). 
        It can have a string[] args parameter that can be used to retrieve the arguments passed while running 
        the application.
        The following example displays the command-line arguments using the args parameter.

         you have to set your .NET framework path to your environment variable Path. This folder is generally 
         C:\Windows\Microsoft.NET\Framework folder. If you are using .NET Framework 4.x then there will be a 
         folder something like v4.0.30319 based on the version installed on your PC.

         After setting a Path, open the command prompt and navigate to the folder where you saved your Program.cs
          or .cs file and compile the file using the csc command, as shown below.
          
            C:\pathtoapp>csc /out:myprogram.exe Program.cs

        The above command will compile the Program.cs and generate the myprogram.exe.

        Now, to run the application and pass the arguments to the Main() method, type the program name and
         specify arguments and press enter

            C:\pathtoapp>myprogram.exe "First Arg" 10 20
        */
        static void Main(string[] args)
        {
            // Program execution starts from here
            Console.WriteLine("Total arguments: {0}", args.Length);

            Console.WriteLine("Arguments: ");

            foreach (var arg in args)
            {
                Console.WriteLine(arg + ", ");
            }
        }
    }
}
