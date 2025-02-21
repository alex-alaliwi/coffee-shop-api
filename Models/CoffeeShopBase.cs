namespace CoffeeShopAPI.Models
{
    public abstract class CoffeeShopBase
    {
        public string Name { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
    }
}
