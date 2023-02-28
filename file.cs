using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practicheskai_2
{
    internal class file
    {
        private static object JsonConvert;

        public static void Serialize<T>(List<T> note)
        {
            string json = JsonConvert.SerializeObject(note);
            File.WriteAllText("C:\\Users\\User\\source\\repos\\Ежедневник2.json", json);
        }

        public static List<T> Mydeserializer<T>()
        {
            string json = File.ReadAllText("C:\\Users\\User\\source\\repos\\Ежедневник2.json");
            List<T> note = JsonConvert.DeserializeObject<List<T>>(json);
            return note;
        }
    }
}
