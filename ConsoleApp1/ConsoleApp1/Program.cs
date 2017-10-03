//hi
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
            //display the contents of the data structure.You must use the foreach loop when displaying the data. Handle any errors and inform the user.
            foreach (string item in myStack)
            {
                Console.WriteLine(item);
            }
        }

        static void deleteStack()
        {
            Console.WriteLine("Which would you like to delete?");
            string userInput = Console.ReadLine();

            Stack<string> temp = new Stack<string>();

            while ((myStack.Pop()) != userInput)
            {
                temp.Push(myStack.Pop());
            }

            while (temp.Pop() != null)
            {
                myStack.Push(temp.Pop());
            }
        }

        static void deleteAllStack()
        {
            myStack.Clear();
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

        }

        static void deleteQueue()
        {
            Console.WriteLine("Which would you like to delete?");
            string userInput = Console.ReadLine();
            Queue<string> myHoldQueue = new Queue<string>();
            if (myQueue.Peek() == userInput)
            {
                myQueue.Dequeue();
            }
            else
            {
                myHoldQueue.Enqueue(myQueue.Dequeue());
            }


            for (int iCount = 0; myHoldQueue.Count > 0; iCount++)
            {
                myQueue.Enqueue(myHoldQueue.Dequeue());
                Console.WriteLine(myQueue.ElementAt(iCount));
            }
}
            static void deleteAllQueue()
            {
                myQueue.Clear();
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
            myDictionary.Add(userInput, userInt); //is this right?
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
            }

        static void deleteAllDictionary()
        {
            myDictionary.Clear();
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
                                break;
                            case 5:
                                deleteAllStack();
                                break;
                            case 6:
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
                                break;
                            case 5:
                                deleteAllQueue();
                                break;
                            case 6:
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
                                break;
                            case 5:
                                deleteAllDictionary();
                                break;
                            case 6:
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
