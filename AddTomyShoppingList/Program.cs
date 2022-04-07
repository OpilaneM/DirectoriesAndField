using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTomyShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\mraud\source\RandomFile\ShoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Would you like to add a item to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter the name of item you wish to purchase:");
                    string userItem = Console.ReadLine();
                    myShoppingList.Add(userItem);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Go Shopping!");
                }
            }

            Console.Clear();
            foreach (string item in myShoppingList)
            {
                Console.WriteLine($"Your item {item}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);

            Console.Read();

        }
    }
}
