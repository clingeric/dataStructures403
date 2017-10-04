using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //STACK

        static Stack<string> myStack = new Stack<string>();

        static void addToStack()
        {
            //prompts the user to enter a string and then inserts the input into the data structure.
            Console.WriteLine("Enter a string");
            string userInput = Console.ReadLine();
            myStack.Push(userInput);
        }
        static void addHugeToStack()
        {
            //first clears the data structure and 
            //then generate 2,000 items in the data structure with the value of “New Entry” concatenated with the number. 
            //For example, New Entry 1, New Entry 2, New Entry 3. For the dictionary, the key will be the generated string ("New Entry 2") and the value will be the current number (2).
            myStack.Clear();
            for (int i = 1; i < 2001; i++)
            {
                myStack.Push("New Entry " + i);
            }
        }
        static void displayStack()
        {
            //display the contents of the data structure. You must use the foreach loop when displaying the data. Handle any errors and inform the user.
            foreach (string item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void deleteFromStack()
        {
            //prompts the user to enter an item and then deletes that item from the data structure
            Console.WriteLine("Which item do you want to delete?");
            string userInput = Console.ReadLine();

            if (myStack.Contains(userInput))
            {
                Stack<string> tempStack = new Stack<string>();
                while (myStack.Count() > 0)
                {
                    if (userInput == myStack.Peek())
                    {
                        myStack.Pop();
                    }
                    else
                    {
                        tempStack.Push(myStack.Pop());
                    }
                }

                while (tempStack.Count() > 0)
                {
                    myStack.Push(tempStack.Pop());
                }
            }
            else
            {
                Console.WriteLine("Stack does not contain " + userInput);
            }
        }

        static void deleteAllStack()
        {
            myStack.Clear();
        }

        static void searchStack()
        {
            //allows user to search for item in the stack
            //get value to search from user
            Console.WriteLine("Enter value to search: ");
            string valueToSearch = Console.ReadLine();
            Console.WriteLine();

            //start a timer
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            if (myStack.Contains(valueToSearch))
            {
                //user input found in stack - stop timer
                sw.Stop();
                
                //get and display found value
                Console.WriteLine("Value found.");
                Console.WriteLine("Time elapsed: {0}", sw.Elapsed);
            }
            else
            {
                //user input not found in stack - stop timer
                sw.Stop();

                //write time elapsed
                Console.WriteLine("Value not found.");
                Console.WriteLine("Time Elapsed: {0}", sw.Elapsed);
            }
            Console.WriteLine();
        }


        //QUEUE

        static Queue<string> myQueue = new Queue<string>();

        static void addToQueue()
        {
            //prompts the user to enter a string and then inserts the input into the data structure.
            Console.WriteLine("Enter a string");
            string userInput = Console.ReadLine();
            myQueue.Enqueue(userInput);
        }
        static void addHugeToQueue()
        {
            //first clears the data structure and 
            //then generate 2,000 items in the data structure with the value of “New Entry” concatenated with the number. 
            //For example, New Entry 1, New Entry 2, New Entry 3. For the dictionary, the key will be the generated string ("New Entry 2") and the value will be the current number (2).
            myQueue.Clear();
            for (int i = 0; i < 2001; i++)
            {
                myQueue.Enqueue("New Entry " + i);
            }
        }
        static void displayQueue()
        {
            //display the contents of the data structure.You must use the foreach loop when displaying the data. Handle any errors and inform the user.
            foreach (string item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void deleteFromQueue()
        {
            //prompts the user to enter an item and then deletes that item from the data structure
            Console.WriteLine("Which item do you want to delete?");
            string userInput = Console.ReadLine();

            if (myQueue.Contains(userInput))
            {
                Queue<string> tempQueue = new Queue<string>();
                while (myQueue.Count() > 0)
                {
                    if (userInput == myQueue.Peek())
                    {
                        myQueue.Dequeue();
                    }
                    else
                    {
                        tempQueue.Enqueue(myQueue.Dequeue());
                    }
                }

                while (tempQueue.Count() > 0)
                {
                    myQueue.Enqueue(tempQueue.Dequeue());
                }
            }
            else
            {
                Console.WriteLine("Queue does not contain " + userInput);
            }
        }
        static void deleteAllQueue()
            {
                myQueue.Clear();
            }

        static void searchQueue()
        {
            //allows user to search for item in the queue
            //get value to search from user
            Console.WriteLine("Enter value to search: ");
            string valueToSearch = Console.ReadLine();
            Console.WriteLine();

            //start a timer
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            if (myQueue.Contains(valueToSearch))
            {
                //user input found in queue - stop timer
                sw.Stop();

                //get and display found value
                Console.WriteLine("Value found.");
                Console.WriteLine("Time elapsed: {0}", sw.Elapsed);
            }
            else
            {
                //user input not found in queue - stop timer
                sw.Stop();

                //write time elapsed
                Console.WriteLine("Value not found.");
                Console.WriteLine("Time Elapsed: {0}", sw.Elapsed);
            }
            Console.WriteLine();
        }


        //DICTIONARY

        static Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        static void addToDictionary()
        {
            //prompts the user to enter a string and then inserts the input into the data structure.
            Console.WriteLine("Enter a string key");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter a int value");
            string userIntString = Console.ReadLine();
            int userInt = Convert.ToInt32(userIntString);
            myDictionary.Add(userInput, userInt); //do we need to check for multiple key values?
        }
        static void addHugeToDictionary()
        {
            //first clears the data structure and 
            //then generate 2,000 items in the data structure with the value of “New Entry” concatenated with the number. 
            //For example, New Entry 1, New Entry 2, New Entry 3. For the dictionary, the key will be the generated string ("New Entry 2") and the value will be the current number (2).
            myDictionary.Clear();
            for (int i = 1; i < 2001; i++)
            { 
                myDictionary.Add("New Entry " + i.ToString(), i);
            }
        }
        static void displayDictionary()
        {
            //display the contents of the data structure. You must use the foreach loop when displaying the data. Handle any errors and inform the user.
            foreach (KeyValuePair<string, int> item in myDictionary)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }
            Console.WriteLine();
        }

        static void deleteDictionary()
        {
            Console.WriteLine("Which would you like to delete?");
            string userInput = Console.ReadLine();

            for (int iCount = 0; iCount < myDictionary.Count; iCount++)

                if (myDictionary.ContainsKey(userInput))
                {
                    myDictionary.Remove(userInput);
                }

                else
                {
                    Console.WriteLine("Dictionary does not contain " + userInput);
                }
        }

        static void deleteAllDictionary()
        {
            myDictionary.Clear();
        }

        static void searchDictionary()
        {
            //allows user to search for item in the dictionary
            //get key and value to search from user
            Console.WriteLine("Enter key to search: ");
            string keyToSearch = Console.ReadLine();
            Console.WriteLine();

            //start a timer
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            if (myDictionary.ContainsKey(keyToSearch))
            {
                //user input found in dictionary - stop timer
                sw.Stop();

                //get and display found value
                Console.WriteLine("Key found.");
                Console.WriteLine("Time elapsed: {0}", sw.Elapsed);
            }
            else
            {
                //user input not found in dictionary - stop timer
                sw.Stop();

                //write time elapsed
                Console.WriteLine("Key not found.");
                Console.WriteLine("Time Elapsed: {0}", sw.Elapsed);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int userInt;
            bool keepGoing = true;

            while (keepGoing == true)
            {
                do
                {
                    Console.WriteLine("1. Stack");
                    Console.WriteLine("2. Queue");
                    Console.WriteLine("3. Dictionary");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine();
                }
                while (!int.TryParse(Console.ReadLine(), out userInt));
                Console.WriteLine();
                switch (userInt)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("1. Add one item to Stack");
                            Console.WriteLine("2. Add Huge List of Items to Stack");
                            Console.WriteLine("3. Display Stack");
                            Console.WriteLine("4. Delete from Stack");
                            Console.WriteLine("5. Clear Stack");
                            Console.WriteLine("6. Search Stack");
                            Console.WriteLine("7. Return to Main Menu");
                            Console.WriteLine();
                        }
                        while (!int.TryParse(Console.ReadLine(), out userInt));
                        Console.WriteLine();
                        switch (userInt)
                        {
                            case 1:
                                addToStack();
                                break;
                            case 2:
                                addHugeToStack();
                                break;
                            case 3:
                                displayStack();
                                break;
                            case 4:
                                deleteFromStack();
                                break;
                            case 5:
                                deleteAllStack();
                                break;
                            case 6:
                                searchStack();
                                break;
                            case 7:
                                break;
                            default:
                                break;
                        }

                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("1. Add one item to Queue");
                            Console.WriteLine("2. Add Huge List of Items to Queue");
                            Console.WriteLine("3. Display Queue");
                            Console.WriteLine("4. Delete from Queue");
                            Console.WriteLine("5. Clear Queue");
                            Console.WriteLine("6. Search Queue");
                            Console.WriteLine("7. Return to Main Menu");
                            Console.WriteLine();
                        }
                        while (!int.TryParse(Console.ReadLine(), out userInt));
                        Console.WriteLine();
                        switch (userInt)
                        {
                            case 1:
                                addToQueue();
                                break;
                            case 2:
                                addHugeToQueue();
                                break;
                            case 3:
                                displayQueue();
                                break;
                            case 4:
                                deleteFromQueue();
                                break;
                            case 5:
                                deleteAllQueue();
                                break;
                            case 6:
                                searchQueue();
                                break;
                            case 7:
                                break;
                            default:
                                break;
                        }

                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("1. Add one item to Dictionary");
                            Console.WriteLine("2. Add Huge List of Items to Dictionary");
                            Console.WriteLine("3. Display Dictionary");
                            Console.WriteLine("4. Delete from Dictionary");
                            Console.WriteLine("5. Clear Dictionary");
                            Console.WriteLine("6. Search Dictionary");
                            Console.WriteLine("7. Return to Main Menu");
                            Console.WriteLine();
                        }
                        while (!int.TryParse(Console.ReadLine(), out userInt));
                        Console.WriteLine();
                        switch (userInt)
                        {
                            case 1:
                                addToDictionary();
                                break;
                            case 2:
                                addHugeToDictionary();
                                break;
                            case 3:
                                displayDictionary();
                                break;
                            case 4:
                                deleteDictionary();
                                break;
                            case 5:
                                deleteAllDictionary();
                                break;
                            case 6:
                                searchDictionary();
                                break;
                            case 7:
                                break;
                            default:
                                break;
                        }

                        break;
                    case 4:
                        keepGoing = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
