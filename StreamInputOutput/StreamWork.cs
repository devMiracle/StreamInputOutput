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
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                byte[] textByte = Encoding.Default.GetBytes(text);
                fs.Write(textByte, 0, textByte.Length);

            }

        }
    }
}
