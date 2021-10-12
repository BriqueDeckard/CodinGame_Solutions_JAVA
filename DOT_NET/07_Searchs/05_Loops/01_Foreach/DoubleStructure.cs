using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Foreach
{

    class DoubleStructure : IEnumerable<double>
    {
        private List<double> doubleList;

        /// <summary>
        /// Constructor
        /// </summary>
        public DoubleStructure()
        {
            doubleList = new List<double>(new double[] { 3.14, 1.42, 6.67 });
        }

        // Implementation for the GetEnumerator method.
        public IEnumerator<double> GetEnumerator()
        {
            return doubleList.GetEnumerator();
        }

        // This method is also needed
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
