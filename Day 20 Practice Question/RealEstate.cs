namespace MyConsoleApp
{
    public interface IRealEstateListing
    {
        int ID { get; }
    }

    public class RealEstateListing : IRealEstateListing
    {
        public int ID { get; set; }
        public string? Title{ get; set; }
        public string? Description{ get; set; }
        public int Price { get; set; }
        public string? Location{ get; set; }
    }

    public class RealEstateApp
    {
        private List<IRealEstateListing> _listings = [];
        public void AddListing(IRealEstateListing realEstateListing)
        {
            _listings.Add(realEstateListing);
        }
        public void RemoveListing(int listingID)
        {
            _listings.RemoveAll(l => l.ID == listingID);
        }
        public void UpdateListing(RealEstateListing realEstateListing)
        {
            var exists = _listings.FirstOrDefault(l => l.ID == _listings.ID);
        }
    }
}