using System;

namespace _01_BoxingAndUnboxing
{
    class Program
    {
        /*
        Boxing is the process of converting a value type to the object type 
        or any interface type implemented by this value type. Boxing is implicit.

        all the reference types stored on heap where it contains the address 
        of the value and value type is just an actual value stored on the stack.
        Now, as shown in the first example, int i is assigned to object o.
        Object o must be an address and not a value itself. So, the CLR boxes 
        the value type by creating a new System.Object on the heap and wraps 
        the value of i in it and then assigns an address of that object to o.
        So, because the CLR creates a box on the heap that stores the value,
        the whole process is called 'Boxing'.

        --> See https://stackoverflow.com/questions/2111857/why-do-we-need-boxing-and-unboxing-in-c
        */
        static void Main(string[] args)
        {
            // ---- BOXING ----
            int i = 10;
            object o = i; // Performs boxing

            // A boxing conversion makes a copy of the value. So, changing the value of one variable will not impact others.
            o = 20;
            Console.WriteLine (i);

            // ---- UNBOXING ----
            int j = (int) o;
            double d = (double) (int) o;
            Console.WriteLine (d);
        }
    }
}
