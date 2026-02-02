namespace ConsoleApp
{
    public class Bike
    {
        public string? Model { get; set; }
        public string? Brand { get; set; }
        public int PricePerDay { get; set; }
    }

    public class BikeUtility
    {
        public void AddBikeDetails(string model, string brand, int pricePerDay)
        {
            int key = Program.bikeDetails.Count + 1;
            Bike bike = new()
            {
                Model = model,
                Brand = brand,
                PricePerDay = pricePerDay
            };
            Program.bikeDetails.Add(key, bike);
        }

        public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
        {
            var dict = Program.bikeDetails.Values.GroupBy(b => b.Brand ?? "Unknown").OrderBy(g => g.Key).ToDictionary(g => g.Key,g => g.ToList());

            return new SortedDictionary<string, List<Bike>>(dict);
        }
    }
    public class Program
    {
        public static SortedDictionary<int, Bike> bikeDetails = [];
        public static void Main()
        {
            BikeUtility utility = new();
            int choice;

            do
            {
                Console.WriteLine("1. Add Bike Details");
                Console.WriteLine("2. Group Bikes By Brand");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choice");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the brand");
                        string brand = Console.ReadLine();

                        Console.WriteLine("Enter the model");
                        string model = Console.ReadLine();

                        Console.WriteLine("Enter the price per day");
                        int price = int.Parse(Console.ReadLine());

                        utility.AddBikeDetails(model, brand, price);
                        Console.WriteLine("Bike details added successfully");
                        Console.WriteLine();
                        break;

                    case 2:
                        var groupedBikes = utility.GroupBikesByBrand();

                        foreach (var brandGroup in groupedBikes)
                        {
                            Console.WriteLine("\n"+brandGroup.Key+":");
                            foreach (var bike in brandGroup.Value)
                            {
                                Console.WriteLine(bike.Model);
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        break;
                }

            } while (choice != 3);
        }
    }
}