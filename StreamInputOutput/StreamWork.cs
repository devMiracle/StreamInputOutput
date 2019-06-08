using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamInputOutput
{
    class StreamWork
    {
        public static void WriteFile(string filePath, string text)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    sw.WriteLine(text);
            }
        }
        public static void ReadFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                    Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
