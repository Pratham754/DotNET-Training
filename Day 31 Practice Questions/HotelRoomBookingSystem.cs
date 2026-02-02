using System;

namespace MyConsoleApp
{
    #region Models

    public class Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
    {
        public int RoomNumber { get; set; } = roomNumber;
        public string? RoomType { get; set; } = roomType;
        public double PricePerNight { get; set; } = pricePerNight;
        public bool IsAvailable { get; set; } = isAvailable;
    }

    #endregion

    #region Interfaces

    public interface IHotelManager
    {
        /// <summary>
        /// Adds a new room to the hotel if the room number does not already exist.
        /// </summary>
        static abstract void AddRoom(int roomNumber, string type, double price);

        /// <summary>
        /// Books an available room for the specified number of nights.
        /// </summary>
        /// <returns>True if the booking was successful; otherwise, false.</returns>
        static abstract bool BookRoom(int roomNumber, int nights);

        /// <summary>
        /// Retrieves all available rooms within the specified price range.
        /// </summary>
        static abstract List<Room> GetAvailableRoomsByPriceRange(double min, double max);

        /// <summary>
        /// Groups all rooms by their room type.
        /// </summary>
        Dictionary<string, List<Room>> GroupRoomsByType();
    }

    #endregion

    #region Services

    public class HotelManager : IHotelManager
    {
        // Shared in-memory storage for all rooms
        private static readonly List<Room> _rooms = [];

        /// <summary>
        /// Adds a room to the hotel inventory.
        /// Duplicate room numbers are ignored.
        /// </summary>
        public static void AddRoom(int roomNumber, string type, double price)
        {
            // Prevent duplicate room numbers
            if (_rooms.Any(r => r.RoomNumber == roomNumber))
                return;

            _rooms.Add(new Room(roomNumber, type, price, true));
        }

        /// <summary>
        /// Groups all rooms by their type.
        /// </summary>
        public Dictionary<string, List<Room>> GroupRoomsByType()
        {
            return _rooms
                .GroupBy(r => r.RoomType!)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        /// <summary>
        /// Books a room if it exists and is available.
        /// </summary>
        /// <returns>True if booking succeeds; otherwise, false.</returns>
        public static bool BookRoom(int roomNumber, int nights)
        {
            // Locate the requested room
            Room? room = _rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (room == null || !room.IsAvailable)
                return false;

            double totalCost = room.PricePerNight * nights;
            room.IsAvailable = false;

            Console.WriteLine(
                $"Room {room.RoomNumber} booked for {nights} night(s). Total cost: {totalCost:C}"
            );

            return true;
        }

        /// <summary>
        /// Returns available rooms whose price falls within the given range.
        /// </summary>
        public static List<Room> GetAvailableRoomsByPriceRange(double min, double max)
        {
            return _rooms
                .Where(r =>
                    r.IsAvailable &&
                    r.PricePerNight >= min &&
                    r.PricePerNight <= max)
                .ToList();
        }
    }

    #endregion

    #region Application Entry Point

    public class Program
    {
        /// <summary>
        /// Entry point of the Hotel Management console application.
        /// </summary>
        public static void Main()
        {
            HotelManager hotel = new();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== Hotel Management System ===");
                Console.WriteLine("1. Add Room");
                Console.WriteLine("2. View Available Rooms by Type");
                Console.WriteLine("3. Book a Room");
                Console.WriteLine("4. Find Rooms by Price Range");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Room Number: ");
                        int roomNumber = int.Parse(Console.ReadLine()!);

                        Console.Write("Room Type: ");
                        string type = Console.ReadLine()!;

                        Console.Write("Price per Night: ");
                        double price = double.Parse(Console.ReadLine()!);

                        HotelManager.AddRoom(roomNumber, type, price);
                        Console.WriteLine("Room added successfully.");
                        break;

                    case "2":
                        Console.WriteLine("Available Rooms by Type:");
                        var groupedRooms = hotel.GroupRoomsByType();

                        foreach (var group in groupedRooms)
                        {
                            Console.WriteLine($"\n{group.Key}:");
                            foreach (var room in group.Value.Where(r => r.IsAvailable))
                            {
                                Console.WriteLine($"  Room {room.RoomNumber} - ${room.PricePerNight}");
                            }
                        }
                        break;

                    case "3":
                        Console.Write("Room Number to Book: ");
                        int bookRoomNumber = int.Parse(Console.ReadLine()!);

                        Console.Write("Number of Nights: ");
                        int nights = int.Parse(Console.ReadLine()!);

                        if (!HotelManager.BookRoom(bookRoomNumber, nights))
                            Console.WriteLine("Room booking failed. Room may be unavailable.");
                        break;

                    case "4":
                        Console.Write("Minimum Price: ");
                        double min = double.Parse(Console.ReadLine()!);

                        Console.Write("Maximum Price: ");
                        double max = double.Parse(Console.ReadLine()!);

                        var rooms = HotelManager.GetAvailableRoomsByPriceRange(min, max);

                        if (rooms.Count == 0)
                        {
                            Console.WriteLine("No rooms found in this price range.");
                        }
                        else
                        {
                            Console.WriteLine("Available Rooms:");
                            foreach (var room in rooms)
                            {
                                Console.WriteLine(
                                    $"Room {room.RoomNumber} - {room.RoomType} - ${room.PricePerNight}"
                                );
                            }
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