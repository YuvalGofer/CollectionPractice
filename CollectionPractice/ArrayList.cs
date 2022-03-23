using System.Collections;

bool exit = false;
ArrayList myArray = new ArrayList();
while (exit == false)
{
    Console.WriteLine("Choose an option from the following list:\n\t"+
                      "a - Add\n\td - Remove\n\te - Enumerate\n\tb - Contain\n\tc - Clear\n\tq - Quit\n"+ 
                       "Your option?");
    string option = Console.ReadLine();
    string userInput = " ";
    switch (option)
    {
        case "a":
            Console.WriteLine("Add something to your list..");
            userInput = Console.ReadLine();
            myArray.Add(userInput);
            Console.WriteLine("Text added!");
            break;

        case "d":
            Console.WriteLine("Remove something from your list");
            userInput = Console.ReadLine();
            myArray.Remove(userInput);
            Console.WriteLine("Text removed!");
            break;

        case "e":
            foreach (string s in myArray)
                Console.WriteLine(s);
            break;

        case "b":
            Console.WriteLine("Search for something in the list"); 
            string search = Console.ReadLine();
            bool find = myArray.Contains(search);
            if (find)
                Console.WriteLine($"The list contain {search}");
            else
                Console.WriteLine($"The list does't contain {search}");
            break;

        case "c":
            myArray.Clear();
            Console.WriteLine("List was cleared!");
            break;

        case "q":
            exit = true;
            break;
    }
}
