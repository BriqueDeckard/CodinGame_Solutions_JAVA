using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Foreach
{
    public class CustomerEnumerable : IEnumerable<Customer>
    {
        /// <summary>
        /// The core of the IEnumerable
        /// </summary>
        /// <typeparam name="Customer"></typeparam>
        /// <returns></returns>
        private List<Customer> customersList = new List<Customer>();

        /// <summary>
        /// Instantiates a new CustomerEnumerable object.
        /// </summary>
        public CustomerEnumerable()
        {
            customersList =
                new List<Customer>(new Customer[] {
                        new Customer("John NHOJ"),
                        new Customer("Lea AEL")
                    });
        }

        /// <summary>
        /// ---- OBLIGATORY ----
        /// yield indicates that it is an iterator
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Customer> GetEnumerator()
        {
            foreach (Customer cust in customersList)
            {
                yield return cust;
            }
        }

        /// <summary>
        /// ---- OBLIGATORY ----
        /// </summary>
        /// <returns></returns>
        IEnumerator GetEnumerator1()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// ---- OBLIGATORY ----
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator1();
        }
    }

    /// <summary>
    /// When you implements a custom IEnumerable, you have to implements a IEnumerator too.
    /// </summary>
    public class CustomerEnumerator : IEnumerator<Customer>
    {
        /// <summary>
        /// The "current" mechanism for IEnumerator
        /// </summary>
        private Customer _current;

        /// <summary>
        /// Same thing
        /// </summary>
        /// <value></value>
        public Customer Current
        {
            get
            {
                if (_current == null)
                {
                    throw new InvalidOperationException();
                }
                return _current;
            }
        }

        private object Current1
        {
            get
            {
                return this.Current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current1;
            }
        }


#region IEnumerator methods
        public bool MoveNext()
        {
            if (_current == null)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            _current = null;
        }

        private bool disposedValue = false;

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    // Dispose of managed resources
                }

                _current = null;
            }
            this.disposedValue = true;
        }
#endregion
    }
}
