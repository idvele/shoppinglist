using System;
using System.IO;
using System.Text;

namespace _8._6_Shoppinglist
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(@"C:\Users\ilari\source\repos\8.6 Shoppinglist\Kauppalista.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
            Console.ReadLine();

            Console.WriteLine("Add item to shopping list: ");
            string item = Console.ReadLine();

            string path = @"C:\Users\ilari\source\repos\8.6 Shoppinglist\Kauppalista.txt";

            File.AppendAllText(path, item + Environment.NewLine);


        }
    }
}
