using System;

namespace BookStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // 1. Read initial input
            Console.Write("Enter Book Details: ");
            string input = Console.ReadLine() ?? "";
            // Format: BookID Title Price Stock
            var parts = input.Split(' ');
            if (parts.Length < 4) throw new InvalidBookDataException("Invalid input format.");

            Book book = new Book();

            book.Id = parts[0];
            book.Title = parts[1];
            book.Price = Convert.ToInt32(parts[2]);
            book.Stock = Convert.ToInt32(parts[3]);

            try
            {
                BookUtility utility = new BookUtility(book);

                while (true)
                {
                    // TODO:
                    Console.WriteLine("Display menu:" +
                                      "\n1 -> Display book details" +
                                      "\n2 -> Update book price" +
                                      "\n3 -> Update book stock" +
                                      "\n4 -> Exit"
                    );

                    //int choice = 0; // TODO: Read user choice
                    int choice = Convert.ToInt32(Console.ReadLine() ?? "0");

                    switch (choice)
                    {
                        case 1:
                            utility.GetBookDetails();
                            break;

                        case 2:
                            // TODO:
                            // Read new price
                            int newPrice = Convert.ToInt32(Console.ReadLine() ?? "0");
                            // Call UpdateBookPrice()
                            utility.UpdateBookPrice(newPrice);
                            break;

                        case 3:
                            // TODO:
                            // Read new stock
                            int newStock = Convert.ToInt32(Console.ReadLine() ?? "0");
                            // Call UpdateBookStock()
                            utility.UpdateBookStock(newStock);
                            break;

                        case 4:
                            Console.WriteLine("Thank You");
                            return;

                        default:
                            // TODO: Handle invalid choice
                            throw new InvalidBookDataException("Invalid choice. Please select a valid option.");

                    }
                }
            }
            catch (InvalidBookDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}