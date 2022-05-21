using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> travelRoute = Console.ReadLine()
                .Split("||")
                .ToList();
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < travelRoute.Count; i++)
            {
                string[] elements = travelRoute[i].Split(" ");
                string command = elements[0];
                

                if (command == "Travel")
                {
                    int integer = int.Parse(elements[1]);
                    if (fuel >= integer)
                    {
                        fuel -= integer;
                        Console.WriteLine($"The spaceship travelled {integer} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }
                }
                else if (command == "Enemy")
                {
                    int integer = int.Parse(elements[1]);
                    if (ammunition >= integer)
                    {
                        ammunition -= integer;
                        Console.WriteLine($"An enemy with {integer} armour is defeated.");
                    }
                    else
                    {
                        if (fuel >= integer)
                        {
                            fuel -= integer;
                            Console.WriteLine($"An enemy with {integer} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            break;
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int integer = int.Parse(elements[1]);
                    fuel += integer;
                    ammunition += integer * 2;
                    Console.WriteLine($"Ammunitions added: {integer * 2}.");
                    Console.WriteLine($"Fuel added: {integer}.");
                }
                else if (command == "Titan")
                {
                    Console.WriteLine($"You have reached Titan, all passengers are safe.");
                    break;
                }
            }
        }
    }
}
