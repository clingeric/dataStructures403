using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
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
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
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
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
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
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
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
