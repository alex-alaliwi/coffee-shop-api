using CoffeeShopAPI.Models;

namespace CoffeeShopAPI.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.CoffeeShops.Any())
            {
                context.CoffeeShops.AddRange(
                    new CoffeeShop
                    {
                        Name = "Cream Coffee",
                        OpeningTime = "08:00",
                        ClosingTime = "18:00",
                        Location = "Downtown",
                        Rating = 4.5
                    },
                    new CoffeeShop
                    {
                        Name = "Coffee Stop",
                        OpeningTime = "10:00",
                        ClosingTime = "22:00",
                        Location = "Uptown",
                        Rating = 4.8
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
