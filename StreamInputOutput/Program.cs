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
        static void ClientDialog()
        {
            string text;
            char input;
            bool key;
            do
            {
                key = false;
                text = Console.ReadLine();
                if (char.TryParse(text, out input))
                    input = char.Parse(text);
                else
                {
                    Console.WriteLine("Need one symbol. Try again(Y/n):");
                    key = true;
                    continue;
                }

                if (input != 'Y' && input != 'y' && input != 'N' && input != 'n')
                {
                    key = true;
                    Console.WriteLine("unknown symbol. Try again(Y/n):");
                }
            } while (key);
            if (input == 'N' || input == 'n')
            {
                Environment.Exit(0);
            }
            else if (input == 'Y' || input == 'y')
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                string data = name + " : " + email;
                StreamWork.WriteFile(filePath, data);
                Console.WriteLine("Data recorded!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(StreamWork.ReadFile(filePath));
                Console.ResetColor();
            }
        }
        static string filePath = "data.txt";
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 20);
            Console.SetBufferSize(60, 20);
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(StreamWork.ReadFile(filePath));
                Console.ResetColor();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!\nCreate new File?(Y/n):");
                ClientDialog();
            }
            do
            {
                Console.WriteLine("Exchange info?(Y/n)");
                ClientDialog();

            } while (true);


        }
    }
}
