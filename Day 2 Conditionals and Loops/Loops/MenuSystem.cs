// Menu System: Use do-while and switch to create a persistent console menu.
using System;
namespace Github
{
    public class MenuSystem
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Option 1");
                Console.WriteLine("2. Option 2");
                Console.WriteLine("3. Option 3");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You selected Option 1.");
                        break;
                    case 2:
                        Console.WriteLine("You selected Option 2.");
                        break;
                    case 3:
                        Console.WriteLine("You selected Option 3.");
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 4);
        }
    }
}