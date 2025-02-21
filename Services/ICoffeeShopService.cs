using CoffeeShopAPI.DTOs;

namespace CoffeeShopAPI.Services
{
    public interface ICoffeeShopService
    {
        IEnumerable<CoffeeShopResponseDto> GetAllShops();
        void CreateShop(CoffeeShopCreateDto dto);
    }
}
