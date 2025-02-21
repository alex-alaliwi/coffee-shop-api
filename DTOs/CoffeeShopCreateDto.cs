namespace CoffeeShopAPI.DTOs
{
    public class CoffeeShopCreateDto
    {
        public string Name { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
    }
}
