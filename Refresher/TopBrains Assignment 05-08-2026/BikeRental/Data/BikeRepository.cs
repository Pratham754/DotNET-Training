using BikeRental.Model;

namespace BikeRental.Data
{
    public static class BikeRepository
    {
        public static SortedDictionary<int, Bike> BikeDetails { get; } = new SortedDictionary<int, Bike>();
    }
}