using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
                string rootDirectory = @"C:\Users\mraud\source\RandomFile";
                Console.WriteLine("Enter directory name;");
                string newDirectory = Console.ReadLine();
                Console.WriteLine("Enter file name;");

                string fileName = Console.ReadLine();




                if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
                {
                    Console.WriteLine($"Directory and File exist.");

                }
                else
                {
                    Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                    File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

                }

            Console.Read();


        }


    }
}
