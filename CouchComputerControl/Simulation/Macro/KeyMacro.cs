using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouchComputerControl.Simulation.Macro
{
    public class KeyMacro
    {
        public const int KEYDURATION = 10;

        public string Name { get; private set; }
        public KeyMacroRecord[] Records { get; private set; }
        [JsonIgnore]
        public long Duration { get { return Records.Length > 0 ? Records.Last().Wait + Records.Length * KEYDURATION : 0; } }

        public KeyMacro(string name, KeyMacroRecord[] records)
        {
            Name = name;
            Records = records;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, GetRecordString());
        }
        public string GetRecordString()
        {
            return Records.Length > 0 ? string.Join(",", Records.Select(x => x.ToString()).ToArray()) : "empty";
        }
    }
}
