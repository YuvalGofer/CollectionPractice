using System.Collections;
//
Hashtable keyValue = new Hashtable();
bool exit = false;
while (exit == false)
{
    Console.WriteLine("Choose an option from the following list:\n\t" +
                      "a - Add\n\td - Remove\n\te - Enumerate\n\tb - Contain\n\tc - Clear\n\tq - Quit\n" +
                       "Your option?");
    string option = Console.ReadLine();
    string userInput = " ";
    Console.Clear();    
    switch (option)
    {
        case "a":
            Console.WriteLine("Enter first name and last name with comma seperated");
            userInput = Console.ReadLine();
            keyValue.Add(userInput, userInput);
            Console.WriteLine("Names was added!");
            break;

        case "d":
            Console.WriteLine("Enter first and last name to remove from list");
            userInput = Console.ReadLine();
            keyValue.Remove(userInput);
            Console.WriteLine("Names was removed!");
            break;


        case "e":
            Console.WriteLine("Your list contain:");
            foreach (DictionaryEntry d in keyValue)
                Console.WriteLine((string?)d.Key, d.Value);
            break;

        case "b":
            Console.WriteLine("Check if list contain first and last names");
            string checkIfContain = Console.ReadLine();
            bool check = keyValue.ContainsKey(checkIfContain);
            if (check)
                Console.WriteLine($"List contain {checkIfContain}");
            else
                Console.WriteLine($"List does't contain {checkIfContain}");
            break;

        case "c":
            keyValue.Clear();
            Console.WriteLine("List was cleared!");
            break;

        case "q":
            exit = true;
            break;
    }
}