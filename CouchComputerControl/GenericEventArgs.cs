using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouchComputerControl
{
    public class GenericEventArgs<T> : EventArgs
    {
        public T Item { get; private set; }

        public GenericEventArgs(T item)
        {
            Item = item;
        }
    }
}
