using FluentValidation;
using CoffeeShopAPI.DTOs;

namespace CoffeeShopAPI.Validators
{
    public class CoffeeShopValidator : AbstractValidator<CoffeeShopCreateDto>
    {
        public CoffeeShopValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.OpeningTime).Matches(@"\d{2}:\d{2}");
            RuleFor(x => x.ClosingTime).Matches(@"\d{2}:\d{2}");
        }
    }
}
