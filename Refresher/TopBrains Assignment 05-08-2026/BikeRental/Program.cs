using BikeRental.Service;

namespace BikeRental
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BikeUtility bikeUtility = new BikeUtility();
            int choice;

            while (true)
            {
                Console.WriteLine("1. Add Bike Details");
                Console.WriteLine("2. Group Bikes By Brand");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Model: ");
                        string model = Console.ReadLine()!;

                        Console.Write("Enter Brand: ");
                        string brand = Console.ReadLine()!;

                        Console.Write("Enter Price Per Day: ");

                        if (!int.TryParse(Console.ReadLine(), out int price))
                        {
                            Console.WriteLine("Invalid Price.\n");
                            return;
                        }

                        bikeUtility.AddBikeDetails(model, brand, price);
                        break;

                    case 2:
                        var grouped = bikeUtility.GroupBikesByBrand();
                        Console.WriteLine();

                        foreach (var group in grouped)
                        {
                            Console.WriteLine($"Brand: {group.Key}");

                            foreach (var bike in group.Value)
                            {
                                Console.WriteLine($"   Model : {bike.Model}");
                                Console.WriteLine($"   Price : {bike.PricePerDay}");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Thank you for using Bike Rental System!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.\n");
                        break;
                }
            }
        }
    }
}