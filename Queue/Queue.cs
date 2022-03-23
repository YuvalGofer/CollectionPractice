using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Queue<string> myQueue = new Queue<string>();
            bool exit = false;
            while (exit == false)//Exit while loop
            {
                Console.WriteLine("Choose an option from the following list:\n\t" +
                                  "a - Add\n\td - Remove\n\te - Enumerate\n\tb - Contain\n\tc - Clear\n\tq - Quit\n" +
                                   "Your option?");
                string option = Console.ReadLine();
                string userAddInput = " ";
                string userRemoveInput = " ";
                Console.Clear();
                switch (option)
                {
                    case "a"://Add input
                        Console.WriteLine("Add something to your list..");
                        userAddInput = Console.ReadLine();
                        myQueue.Enqueue(userAddInput);
                        Console.WriteLine("Text was added!");
                        break;

                    case "d"://Remove input
                        Console.WriteLine("Remove first item from your list");
                        userRemoveInput = Console.ReadLine();
                        myQueue.Dequeue();
                        Console.WriteLine($"Text <{userRemoveInput}> was removed!");
                        break;

                    case "e":
                        Console.WriteLine("Your list contain:");
                        foreach (string i in myQueue)
                            Console.WriteLine($"\t{i}");
                        break;

                    case "b":
                        Console.WriteLine("Cheack whether an item exists");
                        string checkIf = Console.ReadLine();
                        bool check = myQueue.Contains(checkIf);
                        if (check)
                            Console.WriteLine($"List contain this <{checkIf}> item!");
                        else
                            Console.WriteLine($"List does't contain this <{checkIf}> item!");
                        break;

                    case "c":
                        myQueue.Clear();
                        Console.WriteLine("List was cleared!");
                        break;

                    case "q":
                        exit = true;
                        break;
                }
            }
        }
    }
}
