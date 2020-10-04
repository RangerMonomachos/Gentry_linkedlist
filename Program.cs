using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentry_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList test = new LinkedList();

            while(true)
            { 
                Console.WriteLine(MainMenu());
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine(test.PrintFirst());
                }
                else if (choice == "2")
                {
                    Console.WriteLine("what do you want to add? ");
                    test.AddEnd(Console.ReadLine());
                }
                else if (choice == "3")
                {
                    Console.WriteLine("What do you want to remove? (case insinsitive) ");
                    Console.WriteLine(test.remove(Console.ReadLine()));
                }
                else if (choice == "4")
                {
                    Console.WriteLine("What do you want to search for? (blank means no item found) ");
                    Console.WriteLine(test.Contains(Console.ReadLine()));
                }
                else if (choice == "5")
                {
                    test.PrintList();
                    Console.WriteLine();
                }
                else if (choice == "6")
                {
                    Console.WriteLine("thank you.");
                    break;
                }
                else
                {
                    Console.WriteLine("did not understand. Please Try again");
                    Console.ReadKey();
                }

            }
            //test.AddEnd("hello");
            //test.AddEnd("My");
            //test.AddEnd("Friend");
            //test.AddStart("Start");
            //Console.WriteLine(test.PrintFirst());
            //Console.WriteLine(test.Contains("NO"));
            //Console.WriteLine(test.Contains("friend"));
            //Console.WriteLine(test.remove("NO"));
            //Console.WriteLine(test.remove("my"));
            //test.PrintList();
            //Console.ReadLine();
        }
        static string MainMenu()
        {
            return "1. Show Head \n2. Add Item\n3. Remove Item\n4. Search For Item\n5. Print\n6. Exit";
        }
    }
}
