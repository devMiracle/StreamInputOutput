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
            string filePath = "data.txt";
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            string data = name + ":" + email;

            StreamWork.WriteFile(filePath, data);
            StreamWork.ReadFile(filePath);
           
            Console.ReadKey();
        }
    }
}
