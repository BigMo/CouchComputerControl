using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouchComputerControl
{
    public class BiGenericEventArgs<T> : EventArgs
    {
        public T Item1 { get; private set; }
        public T Item2 { get; private set; }

        public BiGenericEventArgs(T item1, T item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}
