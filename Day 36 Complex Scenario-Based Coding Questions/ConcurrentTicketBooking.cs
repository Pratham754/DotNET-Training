using System;
using System.Collections.Generic;
using System.Linq;

namespace ConcurrentTicketBooking
{
    public class Seat
    {
        public int SeatNo { get; set; }
        public bool IsBooked { get; set; }
    }

    public class TicketSystem
    {
        private readonly List<Seat> _seats = [];
        private readonly Lock _lock = new();

        public TicketSystem(int count)
        {
            for (int i = 1; i <= count; i++)
                _seats.Add(new Seat { SeatNo = i, IsBooked = false });
        }

        public bool BookSeat(int seatNo, string userId)
        {
            lock (_lock)
            {
                var seat = _seats.FirstOrDefault(s => s.SeatNo == seatNo);

                if (seat == null || seat.IsBooked) return false;

                seat.IsBooked = true;
                Console.WriteLine($"Seat {seatNo} successfully booked by {userId}");
                return true;
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            var system = new TicketSystem(5);

            // User A and User B both try to grab Seat 1
            Console.WriteLine(system.BookSeat(1, "User_A")); // True
            Console.WriteLine(system.BookSeat(1, "User_B")); // False (Already booked)
        }
    }
}