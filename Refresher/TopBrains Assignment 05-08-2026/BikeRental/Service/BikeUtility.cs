using BikeRental.Data;
using BikeRental.Model;

namespace BikeRental.Service
{
    public class BikeUtility
    {
        public void AddBikeDetails(string model, string brand, int pricePerDay)
        {
            Bike bike = new Bike
            {
                Model = model,
                Brand = brand,
                PricePerDay = pricePerDay
            };

            int key = BikeRepository.BikeDetails.Count + 1;
            BikeRepository.BikeDetails[key] = bike;

            Console.WriteLine("Bike details added successfully.\n");
        }

        public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
        {
            SortedDictionary<string, List<Bike>> groupedBikes = new SortedDictionary<string, List<Bike>>();

            foreach (Bike bike in BikeRepository.BikeDetails.Values)
            {
                if (!groupedBikes.ContainsKey(bike.Brand)) groupedBikes[bike.Brand] = new List<Bike>();
                groupedBikes[bike.Brand].Add(bike);
            }

            return groupedBikes;
        }
    }
}