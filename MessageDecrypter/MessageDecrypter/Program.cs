using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([$|%])(?<tag>[A-Z][a-z]{2,})\1[:] \[(?<num1>\d+)\]\|\[(?<num2>\d+)\]\|\[(?<num3>\d+)\]\|$";
            
            int n = int.Parse(Console.ReadLine());
            List<string> inputs = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    int num1 = int.Parse(match.Groups["num1"].Value);
                    int num2 = int.Parse(match.Groups["num2"].Value);
                    int num3 = int.Parse(match.Groups["num3"].Value);
                    string tag = match.Groups["tag"].Value;
                    char ch1 = (char)num1; 
                    char ch2 = (char)num2; 
                    char ch3 = (char)num3;
                    string decryptedMessage = string.Empty;
                    decryptedMessage = decryptedMessage + ch1 + ch2 + ch3;
                    Console.WriteLine($"{tag}: {decryptedMessage}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
