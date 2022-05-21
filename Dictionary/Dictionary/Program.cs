using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dictionary = Console.ReadLine()
                .Split(" | ")
                .ToList();
            Dictionary<string, string> notebook = new Dictionary<string, string>();
            foreach (string item in dictionary)
            {
                string[] tokens = item.Split(": ");
                if (notebook.ContainsKey(tokens[0]))
                {
                    
                }
                else
                {
                    notebook.Add(tokens[0], tokens[1]);
                }
            }

            List<string> words = Console.ReadLine().Split(" | ").ToList();

            string command = Console.ReadLine();
            if (command == "Test")
            {
                foreach (string word in words)
                {
                    foreach (var item in notebook)
                    {
                        if (notebook.ContainsKey(word))
                        {
                            Console.WriteLine($"{item.Key}:");
                            Console.WriteLine($" -{item.Value}");
                        }
                    }
                }
            }
            else if (command == "Hand Over")
            {
                foreach (var item in notebook)
                {
                    Console.Write(item.Key + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
