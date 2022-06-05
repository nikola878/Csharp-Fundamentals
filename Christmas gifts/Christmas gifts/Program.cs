using System;

namespace Christmas_gifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kidsCount = 0;
            int adultCount = 0;
            int toysPrice = 0;
            int sweatersPrice = 0;

            string input = Console.ReadLine();
            while (input != "Christmas")
            {
                int age = int.Parse(input);

                if (age <= 16)
                {
                    kidsCount++;
                    toysPrice += 5;
                }
                else if (age > 16)
                {
                    adultCount++;
                    sweatersPrice += 15;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {adultCount}");
            Console.WriteLine($"Number of kids: {kidsCount}");
            Console.WriteLine($"Money for toys: {toysPrice}");
            Console.WriteLine($"Money for sweaters: {sweatersPrice}");
        }
    }
}
