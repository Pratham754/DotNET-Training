using System;

namespace BookStoreApplication
{
    public class InvalidBookDataException : Exception
    {
        public InvalidBookDataException(){}
        public InvalidBookDataException(string? message) : base(message){}
        public InvalidBookDataException(string? message, Exception? innerException) : base(message, innerException){}
    }
    
    public class BookUtility
    {
        private readonly Book _book;

        public BookUtility(Book book)
        {
            // TODO: Assign book object
            _book = book;
        }

        public void GetBookDetails()
        {
            // TODO:
            // Print format:
            Console.WriteLine($"Details: {_book.Id} {_book.Title} {_book.Price} {_book.Stock}");
        }

        public void UpdateBookPrice(int newPrice)
        {
            // TODO:
            // Validate new price
            if(newPrice < 0) throw new InvalidBookDataException("Price cannot be negative.");
            // Update price
            _book.Price = newPrice;
            // Print:
            Console.WriteLine($"Updated Price: {newPrice}");
        }

        public void UpdateBookStock(int newStock)
        {
            // TODO:
            // Validate new stock
            if (newStock< 0) throw new InvalidBookDataException("Stock cannot be negative.");
            // Update stock
            _book.Stock = newStock;
            // Print:
            Console.WriteLine($"Updated Stock: {newStock}");
        }
    }
}