using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouchComputerControl.Simulation
{
    public class BindableProperty<T>
    {
        public T Value
        {
            get { return fGet != null ? val = fGet() : val; }
            set { val = value; fSet?.Invoke(value); }
        }

        private Func<T> fGet;
        private Action<T> fSet;

        private T val;

        public BindableProperty()
        {
            fGet = null;
        }

        public void Bind(Func<T> f, Action<T> a)
        {
            fGet = f;
            fSet = a;
            fSet?.Invoke(val);
        }
        public void Unbind()
        {
            fGet = null;
            fSet = null;
        }

        public static implicit operator T(BindableProperty<T> bp)
        {
            return bp.Value;
        }
    }
}
