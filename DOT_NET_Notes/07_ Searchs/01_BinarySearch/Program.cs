using System;

namespace _01_BinarySearch
{
    class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Te array to look into
            int[] theArray = { 1, 2, 3, 4, 5, 6, 7 };
            int theValue = 4;

            Console.WriteLine(BinarySearch(theArray, theValue));
        }

        /// <summary>
        /// The binary search algorithm.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string BinarySearch(int[] array, int key)
        {
            int firstNum = 0;
            int lastNum = array.Length - 1;

            while (firstNum <= lastNum)
            {
                int middle = (firstNum + lastNum) / 2;

                // If the middle is the key, then we found it.
                if (key == array[middle])
                {
                    var res = middle + 1;
                    return "L'élément est à l'index : " + res;
                } // else redefine a section with the first numbers
                else if (key < array[middle])
                {
                    lastNum = middle - 1;
                }
                else
                // else redefine a sextion with the last numbers
                {
                    firstNum = middle + 1;
                }
            }
            return "Non trouvé";
        }
    }
}
