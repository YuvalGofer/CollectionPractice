using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class SortedList
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool exit = false;
            string userInput;
            int iD = 0;
            SortedList<int, string> studentsList = new SortedList<int, string>();
            string msg = @"Hi, 
this is a SortedList!
Choose an option from the following list:
                ----------
                a - Add
                d - Remove
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
                switch (userChoice)
                {
                    case "a":
                        {
                            Console.WriteLine("Add student ID..");
                            userInput = Console.ReadLine();
                            iD = Convert.ToInt32(userInput);

                            Console.WriteLine("Add student name..");
                            userInput = Console.ReadLine();
                            studentsList.Add(iD, userInput);
                        }
                        break;

                    case "d":
                        {
                            if (studentsList.Count == 0)
                            {
                                Console.WriteLine("Nothing to remove!");
                                continue;
                            }
                            Console.WriteLine("Remove student from list by typing ID..");
                            userInput = Console.ReadLine();
                            iD = Convert.ToInt32(userInput);
                            if (!studentsList.ContainsKey(iD))
                            {
                                Console.WriteLine($"This {iD} ID's does't exists!");
                                continue;
                            }
                            if (studentsList.TryGetValue(iD, out userInput))
                                studentsList.Remove(iD);
                            Console.WriteLine($"Student: \"{userInput}\" is being deleted!");
                        }
                        break;

                    case "b":
                        {
                            if (studentsList.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                                continue;
                            }
                            Console.WriteLine("Search student by typing ID..");
                            userInput = Console.ReadLine();
                            iD = Convert.ToInt32(userInput);
                            studentsList.ContainsKey(iD);
                            if (studentsList.TryGetValue(iD, out userInput))
                                Console.WriteLine($"Your list contains: \"{userInput}\"");
                            else
                                Console.WriteLine($"Your list does't contains student ID: \"{iD}\"");
                        }
                        break;

                    case "e":
                        if (studentsList.Count == 0)
                        {
                            Console.WriteLine("Nothing to show!");
                            continue;
                        }
                        foreach (var s in studentsList)
                            Console.WriteLine("ID : {0}, Student : {1}", s.Key, s.Value);
                        break;

                    case "c":
                        studentsList.Clear();
                        Console.WriteLine("List was cleared!");
                        break;

                    case "q":
                        Console.WriteLine("Sorry you leaving");
                        exit = true;
                        //Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Something went wrong, try agein..");
                        break;
                }
            }
        }
    }
}
