using CoffeeShopAPI.Data;
using CoffeeShopAPI.DTOs;
using CoffeeShopAPI.Models;

namespace CoffeeShopAPI.Services
{
    public class CoffeeShopService : ICoffeeShopService
    {
        private readonly ApplicationDbContext _context;

        public CoffeeShopService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CoffeeShopResponseDto> GetAllShops()
        {
            return _context.CoffeeShops.Select(shop => new CoffeeShopResponseDto
            {
                Name = shop.Name,
                IsOpen = DateTime.Now.TimeOfDay >= TimeSpan.Parse(shop.OpeningTime) &&
                         DateTime.Now.TimeOfDay <= TimeSpan.Parse(shop.ClosingTime),
                Location = shop.Location,
                Rating = shop.Rating
            }).ToList();
        }

        public void CreateShop(CoffeeShopCreateDto dto)
        {
            var shop = new CoffeeShop
            {
                Name = dto.Name,
                OpeningTime = dto.OpeningTime,
                ClosingTime = dto.ClosingTime,
                Location = dto.Location,
                Rating = dto.Rating
            };
            _context.CoffeeShops.Add(shop);
            _context.SaveChanges();
        }
    }
}
