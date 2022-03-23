using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Stack<string> myStack = new Stack<string>();
            bool exit = false;
            string message = "Choose an option from the following list:\n\t" +
                                 "a - Add\n\td - Remove\n\te - Enumerate\n\tb - Contain\n\tc - Clear\n\tq - Quit\n" +
                                  "Your option?";
            while (exit == false)
            {
                Console.WriteLine(message);
                string option = Console.ReadLine();
                string userAddInput = " ";
                string userRemoveInput = " ";
                Console.Clear();
                switch (option)
                {
                    case "a":
                        Console.WriteLine("Add some text to your list");
                        userAddInput = Console.ReadLine();
                        myStack.Push(userAddInput);
                        Console.WriteLine("\"{0} ", userAddInput + "\"was added!");
                        break;

                    case "d":
                        {
                            if (myStack.Count == 0)
                                Console.WriteLine("The stack is empty!");
                            else
                            {
                                //Console.WriteLine("Remove item from your list");
                                var delItem = myStack.Pop();
                                Console.WriteLine("\"{0} ", delItem + "\"was removed!");
                            }
                            break;
                        }

                    case "e":
                        Console.WriteLine("Your list contain:\t");
                        string str = string.Join(", ", myStack);
                        Console.WriteLine(str);
                        break;

                    case "b":
                        Console.WriteLine("Check whether an item exists");
                        string checkIf = Console.ReadLine();
                        bool check = myStack.Contains(checkIf);
                        if (check)
                            Console.WriteLine($"List contain the item {checkIf} you ask for!");
                        else
                            Console.WriteLine($"List does't contain the item {checkIf} you ask for!");
                        break;

                    case "c":
                        myStack.Clear();
                        Console.WriteLine("List was cleared!");
                        break;

                    case "q":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Something went wrong, try agein");
                        break;
                }
            }
        }
    }
}
