using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection
{
    public class ICollection
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool exit = false;
            string userInput;
            NamesCollection<string> nmList = new NamesCollection<string>();
            string msg = @"Hi, 
this is ICollection for collecting unique names!
Choose an option from the following list:
                ----------
                a - Add name
                d - Remove name
                b - Contain
                e - Enumerate
                c - Clear
                q - Quit
                ----------
Your option?";
            while (exit == false)
            {
                Console.WriteLine(msg);
                string userChoice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (userChoice)
                {
                    case "a":
                        Console.WriteLine("Please add unique name to your list");
                        userInput = Console.ReadLine();
                        nmList.Add(userInput);
                        break;

                    case "d":
                        if (nmList.Count > 0)
                        {
                            Console.WriteLine("Please choose a name to remove..");
                            userInput = Console.ReadLine();
                            nmList.Remove(userInput);
                            Console.WriteLine($"{userInput} was removed!");
                        }
                        else
                            Console.WriteLine("Nothing to remove!");
                        break;

                    case "b":
                        if (nmList.Count > 0)
                        {
                            Console.WriteLine("Search name from the list..");
                            userInput = Console.ReadLine();
                            nmList.Contains(userInput);
                            if (!nmList.Contains(userInput))
                                Console.WriteLine($"{userInput} is not in the list");
                            else
                                Console.WriteLine($"{userInput} is in the list!");
                        }
                        else
                            Console.WriteLine("List is empt!");

                        break;

                    case "e":
                        if (nmList.Count > 0)
                        {
                            Console.WriteLine("Your unique list contains:");
                            foreach (string item in nmList)
                                Console.WriteLine(item);
                        }
                        else
                            Console.WriteLine("List is empty!");
                        break;

                    case "c":
                        nmList.Clear();
                        break;

                    case "q":
                        Console.WriteLine("Sorry to see you leaving, bye bye..");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Wrong tab, try agein!");
                        break;
                }
            }
        }
    }
}
