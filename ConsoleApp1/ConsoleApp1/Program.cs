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
                    break;
                case 2:
                    break;
                case 3:
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
