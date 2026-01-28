using System;

namespace HotelBillingSystem
{
    #region Room Interface
    interface IRoom
    {
        /// <summary>
        /// Calculates the total bill for the stay.
        /// </summary>
        double CalculateTotalBill(int nightsStayed, int joiningYear);
    }
    #endregion

    #region HotelRoom
    class HotelRoom(string roomType, string guestName, double ratePerNight) : IRoom
    {
        public string RoomType { get; set; } = roomType;
        public string GuestName { get; set; } = guestName;
        public double RatePerNight { get; set; } = ratePerNight;

        /// <summary>
        /// Calculates membership duration.
        /// </summary>
        public static int CalculateMembershipYears(int joiningYear)
        {
            int currentYear = 2025; // fixed for consistency
            return currentYear - joiningYear;
        }

        /// <summary>
        /// Calculates bill with discount if applicable.
        /// </summary>
        public double CalculateTotalBill(int nightsStayed, int joiningYear)
        {
            double bill = nightsStayed * RatePerNight;

            if (CalculateMembershipYears(joiningYear) > 3)
            {
                bill *= 0.9; // 10% discount
            }

            return Math.Round(bill, 1);
        }
    }
    #endregion

    #region UserInterface
    class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        public static void Main(string[] args)
        {
            // Deluxe room input
            Console.WriteLine("\nEnter Deluxe Room Details:");
            Console.Write("Guest Name: ");
            string? deluxeGuest = Console.ReadLine();
            Console.Write("Rate per Night: ");
            double deluxeRate = double.Parse(Console.ReadLine());
            Console.Write("Nights Stayed: ");
            int deluxeNights = int.Parse(Console.ReadLine());
            Console.Write("Joining Year: ");
            int deluxeJoinYear = int.Parse(Console.ReadLine());

            HotelRoom deluxeRoom = new("Deluxe Room", deluxeGuest, deluxeRate);

            int deluxeMembership = HotelRoom.CalculateMembershipYears(deluxeJoinYear);
            double deluxeBill = deluxeRoom.CalculateTotalBill(deluxeNights, deluxeJoinYear);

            // Suite room input
            Console.WriteLine("\nEnter Suite Room Details:");
            Console.Write("Guest Name: ");
            string? suiteGuest = Console.ReadLine();
            Console.Write("Rate per Night: ");
            double suiteRate = double.Parse(Console.ReadLine());
            Console.Write("Nights Stayed: ");
            int suiteNights = int.Parse(Console.ReadLine());
            Console.Write("Joining Year: ");
            int suiteJoinYear = int.Parse(Console.ReadLine());

            HotelRoom suiteRoom = new("Suite Room", suiteGuest, suiteRate);

            int suiteMembership = HotelRoom.CalculateMembershipYears(suiteJoinYear);
            double suiteBill = suiteRoom.CalculateTotalBill(suiteNights, suiteJoinYear);

            // Output
            Console.WriteLine("\nRoom Summary:");
            Console.WriteLine($"Deluxe Room: {deluxeGuest}, {deluxeRate:F1} per night, Membership: {deluxeMembership} years");
            Console.WriteLine($"Suite Room: {suiteGuest}, {suiteRate:F1} per night, Membership: {suiteMembership} years");

            Console.WriteLine("\nTotal Bill:");
            Console.WriteLine($"For {deluxeGuest} (Deluxe): {Math.Floor(deluxeBill):F1}");
            Console.WriteLine($"For {suiteGuest} (Suite): {suiteBill:F1}");
        }
    }
    #endregion
}