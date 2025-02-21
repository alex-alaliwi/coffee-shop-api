using Microsoft.AspNetCore.Mvc;
using CoffeeShopAPI.DTOs;
using CoffeeShopAPI.Services;
using FluentValidation;
using FluentValidation.Results;

namespace CoffeeShopAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoffeeShopController : ControllerBase
    {
        private readonly ICoffeeShopService _service;
        private readonly IValidator<CoffeeShopCreateDto> _validator;

        public CoffeeShopController(ICoffeeShopService service, IValidator<CoffeeShopCreateDto> validator)
        {
            _service = service;
            _validator = validator;
        }

        [HttpGet]
        public IActionResult GetShops()
        {
            return Ok(_service.GetAllShops());
        }

        [HttpPost]
        public IActionResult CreateShop([FromBody] CoffeeShopCreateDto dto)
        {
            ValidationResult validationResult = _validator.Validate(dto);

            if (!validationResult.IsValid)
            {
                return BadRequest(new
                {
                    Errors = validationResult.Errors.Select(e => new { e.PropertyName, e.ErrorMessage })
                });
            }

            _service.CreateShop(dto);
            return Ok("Coffee shop created successfully!");
        }
    }
}
