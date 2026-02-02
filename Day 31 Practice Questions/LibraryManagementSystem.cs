using System;

namespace MyConsoleApp
{
    #region Models

    public class Book(string title, string author, string genre, int publicationYear)
    {
        private static int _idCounter = 1;

        public int Id { get; } = _idCounter++;
        public string? Title { get; set; } = title;
        public string? Author { get; set; } = author;
        public string? Genre { get; set; } = genre;
        public int PublicationYear { get; set; } = publicationYear;
    }

    #endregion

    #region Interfaces

    public interface ILibraryUtility
    {
        /// <summary>
        /// Adds a new book to the library collection.
        /// </summary>
        void AddBook(string title, string author, string genre, int year);

        /// <summary>
        /// Groups books by genre and returns them in sorted order.
        /// </summary>
        SortedDictionary<string, List<Book>> GroupBooksByGenre();

        /// <summary>
        /// Retrieves all books written by the specified author.
        /// </summary>
        List<Book> GetBooksByAuthor(string author);

        /// <summary>
        /// Returns the total number of books in the library.
        /// </summary>
        int GetTotalBooksCount();
    }

    #endregion

    #region Services

    public class LibraryUtility : ILibraryUtility
    {
        // In-memory storage for books
        private readonly List<Book> _books = [];

        /// <summary>
        /// Adds a new book to the library collection.
        /// </summary>
        public void AddBook(string title, string author, string genre, int year)
        {
            _books.Add(new Book(title, author, genre, year));
        }

        /// <summary>
        /// Groups books by genre in alphabetical order.
        /// </summary>
        public SortedDictionary<string, List<Book>> GroupBooksByGenre()
        {
            return new SortedDictionary<string, List<Book>>(
                _books
                    .Where(b => !string.IsNullOrWhiteSpace(b.Genre))
                    .GroupBy(b => b.Genre!)
                    .ToDictionary(g => g.Key, g => g.ToList())
            );
        }

        /// <summary>
        /// Retrieves all books by the given author.
        /// </summary>
        public List<Book> GetBooksByAuthor(string author)
        {
            return _books
                .Where(b => b.Author != null && b.Author.Equals(author))
                .ToList();
        }

        /// <summary>
        /// Returns the total number of books stored.
        /// </summary>
        public int GetTotalBooksCount()
        {
            return _books.Count;
        }
    }

    #endregion

    #region Application Entry Point

    public class Program
    {
        /// <summary>
        /// Entry point of the Library Management console application.
        /// </summary>
        public static void Main()
        {
            ILibraryUtility library = new LibraryUtility();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== Library Management System ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View Books Grouped by Genre");
                Console.WriteLine("3. Search Books by Author");
                Console.WriteLine("4. View Library Statistics");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Title: ");
                        string title = Console.ReadLine()!;

                        Console.Write("Author: ");
                        string author = Console.ReadLine()!;

                        Console.Write("Genre: ");
                        string genre = Console.ReadLine()!;

                        Console.Write("Publication Year: ");
                        int year = int.Parse(Console.ReadLine()!);

                        library.AddBook(title, author, genre, year);
                        Console.WriteLine("Book added successfully.");
                        break;

                    case "2":
                        Console.WriteLine("Books Grouped by Genre:");
                        var groupedBooks = library.GroupBooksByGenre();

                        foreach (var group in groupedBooks)
                        {
                            Console.WriteLine($"\nGenre: {group.Key}");
                            foreach (var book in group.Value)
                            {
                                Console.WriteLine(
                                    $"  {book.Title} by {book.Author} ({book.PublicationYear})"
                                );
                            }
                        }
                        break;

                    case "3":
                        Console.Write("Author Name: ");
                        string searchAuthor = Console.ReadLine()!;

                        var booksByAuthor = library.GetBooksByAuthor(searchAuthor);

                        if (booksByAuthor.Count == 0)
                        {
                            Console.WriteLine("No books found for this author.");
                        }
                        else
                        {
                            Console.WriteLine($"Books by {searchAuthor}:");
                            foreach (var book in booksByAuthor)
                            {
                                Console.WriteLine($"  {book.Title} ({book.Genre})");
                            }
                        }
                        break;

                    case "4":
                        Console.WriteLine("Library Statistics:");
                        Console.WriteLine($"Total Books: {library.GetTotalBooksCount()}");

                        var stats = library.GroupBooksByGenre();
                        foreach (var genreGroup in stats)
                        {
                            Console.WriteLine($"{genreGroup.Key}: {genreGroup.Value.Count} book(s)");
                        }
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
    #endregion
}