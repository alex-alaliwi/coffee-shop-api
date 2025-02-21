namespace CoffeeShopAPI.Models
{
    public class CoffeeShop : CoffeeShopBase
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
    }
}
