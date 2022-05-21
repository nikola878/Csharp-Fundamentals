using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] elements = command.Split(" - ");
                string command1 = elements[0];
                string phone = elements[1];
                switch (command1 )
                {
                    case "Add":
                        for (int i = 0; i < phones.Count; i++)
                        {
                            if (phones[i] != phone)
                            {
                                phones.Add(phone);
                            }

                            break;
                        }
                        break;
                    case "Remove":
                        for (int i = 0; i < phones.Count; i++)
                        {
                            if (phones[i] == phone)
                            {
                                phones.RemoveAt(i);
                            }

                            break;
                            
                        }
                        break;
                    case "Bonus phone":
                        string[] twoPhones = phone.Split(":");
                        
                        for (int i = 0; i < phones.Count; i++)
                        {
                            if (phones[i] == twoPhones[0])
                            {
                                phones.Add(twoPhones[1]);
                            }

                            break;
                        }
                        break;
                    case "Last":
                        for (int i = 0; i < phones.Count; i++)
                        {
                            if (phones[i] == phone)
                            {
                                phones.RemoveAt(i);
                                phones.Add(phone);
                            }

                            break;
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
