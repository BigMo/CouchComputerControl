using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CouchComputerControl.Simulation.Macro
{
    public class KeyMacroRecord
    {
        public int Wait { get; private set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Keys Key { get; private set; }
        [JsonIgnore]
        public bool Up
        {
            get { return !downState; }
            set { downState = !value; }
        }
        public bool Down
        {
            get { return downState; }
            set { downState = value; }
        }

        private bool downState;

        public KeyMacroRecord(int wait, Keys key, bool down)
        {
            Wait = wait;
            Key = key;
            downState = down;
        }

        public override string ToString()
        {
            return string.Format("{1}{0}", Key, Down ? "↓" : "↑");
        }
    }
}
