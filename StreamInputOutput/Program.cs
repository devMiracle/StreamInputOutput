using System;
using System.Collections.Generic;
using System.IO;//input; output 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            string data = name + ":" + email;
            FileInfo fileinfo = new FileInfo("clients.txt");
            using (StreamWriter streamWriter = fileinfo.AppendText())
            {
                streamWriter.WriteLine(data);
                streamWriter.Flush();
            }

            using (StreamReader streamReader = new StreamReader(fileinfo.FullName))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
