using CouchComputerControl.Simulation;
using CouchComputerControl.Simulation.Macro;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CouchComputerControl
{
    static class Program
    {
        public static List<KeyMacro> Macros { get; set; }
        public static SimulationProcessor Simulator { get; set; }

        private static string JSON_MACROS = "CouchComputerControl.Macros.json";
        private static string JSON_CONFIG = "CouchComputerControl.Config.json";

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Macros = ParseJson<List<KeyMacro>>(JSON_MACROS);
            if (Macros.Count == 0)
                Macros.Add(CreateDummyMacro());
            Simulator = ParseJson<SimulationProcessor>(JSON_CONFIG);

            Application.Run(new frmMain());
        }

        private static T ParseJson<T>(string file) where T : new() 
        {
            if (!File.Exists(file))
                return new T();

            using (StreamReader reader = new StreamReader(file))
            {
                using (JsonTextReader json = new JsonTextReader(reader))
                    return JsonSerializer.Create().Deserialize<T>(json);
            }
        }

        private static void SaveJson<T>(string file, T obj)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                using (JsonTextWriter json = new JsonTextWriter(writer))
                    JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented }).Serialize(json, obj);
            }
        }

        public static void SaveMacros()
        {
            SaveJson(JSON_MACROS, Macros);
        }

        public static void SaveConfig()
        {
            SaveJson(JSON_CONFIG, Simulator);
        }

        private static KeyMacro CreateDummyMacro()
        {
            return new KeyMacro("Sample",
                new KeyMacroRecord[]{
                new KeyMacroRecord(100, Keys.Shift, true),
                new KeyMacroRecord(100, Keys.H, true),
                new KeyMacroRecord(100, Keys.H, false),
                new KeyMacroRecord(100, Keys.Shift, false),
                new KeyMacroRecord(100, Keys.E, true),
                new KeyMacroRecord(100, Keys.E, false),
                new KeyMacroRecord(100, Keys.L, true),
                new KeyMacroRecord(100, Keys.L, false),
                new KeyMacroRecord(100, Keys.L, true),
                new KeyMacroRecord(100, Keys.L, false),
                new KeyMacroRecord(100, Keys.O, true),
                new KeyMacroRecord(100, Keys.O, false)
                });
        }
    }
}
