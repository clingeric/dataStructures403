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


            Console.WriteLine("1. Stack");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. Dictionary");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            userInt = int.Parse(Console.ReadLine());
            switch (userInt)
            {
                case 1:
                    Console.WriteLine("1.Add one time to Stack");
                    Console.WriteLine("2. Add Huge List of Items to Stack");
                    Console.WriteLine("3. Display Stack");
                    Console.WriteLine("4. Delete from Stack");
                    Console.WriteLine("5. Clear Stack");
                    Console.WriteLine("6. Search Stack");
                    Console.WriteLine("7. Return to Main Menu");
                    Console.WriteLine();

                    int userInput;

                    userInput = int.Parse(Console.ReadLine());
                    switch (userInt\put)
                        case 1:
                    break;
                        
                case 2:
                    Console.WriteLine("1. Add one time to Queue");
                    Console.WriteLine("2. Add Huge List of Items to Queue");
                    Console.WriteLine("3. Display Queue");
                    Console.WriteLine("4. Delete from Queue");
                    Console.WriteLine("5. Clear Queue");
                    Console.WriteLine("6. Search Queue");
                    Console.WriteLine("7. Return to Main Menu");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("1. Add one item to Dictionary");
                    Console.WriteLine("2. Add Huge List of Items to Dictionary");
                    Console.WriteLine("3. Display Dictionary");
                    Console.WriteLine("4. Delete from Dictionary");
                    Console.WriteLine("5. Clear Dictionary");
                    Console.WriteLine("6. Search Dictionary");
                    Console.WriteLine("7. Return to Main Menu");
                    Console.WriteLine();
                    break;
                case 4:
                    break;
                default:
                    break;

               //comment
               //new comment just for Eric
            }

}
    }
}
