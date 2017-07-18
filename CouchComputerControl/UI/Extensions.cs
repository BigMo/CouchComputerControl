using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CouchComputerControl.UI
{
    public static class Extensions
    {
        public static void InvokeSafe(this Control ctrl, Action action)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke((MethodInvoker)(() => { action(); }));
            }
            else
            {
                action();
            }
        }
    }
}
