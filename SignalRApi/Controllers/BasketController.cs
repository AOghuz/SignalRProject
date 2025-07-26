using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntityLayer.Entities;
using SignalRApi.Models;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BasketController : ControllerBase
	{
		private readonly IBasketService _basketService;
        private readonly SignalRContext _context;
        public BasketController(IBasketService basketService,
                          SignalRContext context)    // ← ctor DI
        {
            _basketService = basketService;
            _context = context;
        }
        [HttpGet]
		public IActionResult GetBasketByMenuTableID(int id)
		{
			var values = _basketService.TGetBasketByMenuTableNumber(id);
			return Ok(values);
		}
        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            var values = _context.Baskets
                                 .Include(b => b.Product)
                                 .Where(b => b.MenuTableID == id)
                                 .Select(b => new ResultBasketListWithProducts
                                 {
                                     BasketID = b.BasketID,
                                     MenuTableID = b.MenuTableID,
                                     ProductID = b.ProductID,
                                     ProductName = b.Product.ProductName,
                                     Count = b.Count,
                                     Price = b.Price,
                                     TotalPrice = b.Count * b.Price      // ← güvenli
                                 })
                                 .ToList();

            return Ok(values);
        }


        [HttpPost]
        public IActionResult CreateBasket([FromBody] CreateBasketDto dto)
        {
            // Ürün fiyatını al
            var price = _context.Products
                                .Where(p => p.ProductID == dto.ProductID)
                                .Select(p => p.Price)
                                .FirstOrDefault();

            if (price == 0) return BadRequest("Ürün bulunamadı.");

            // Aynı masa + aynı ürün sepette var mı?
            var basket = _context.Baskets
                                 .FirstOrDefault(b => b.MenuTableID == dto.MenuTableID
                                                   && b.ProductID == dto.ProductID);

            if (basket is null)
            {
                _basketService.TAdd(new Basket
                {
                    ProductID = dto.ProductID,
                    MenuTableID = dto.MenuTableID,
                    Count = 1,
                    Price = price,
                    TotalPrice = price
                });
            }
            else
            {
                basket.Count += 1;
                basket.TotalPrice = basket.Count * basket.Price;
                _basketService.TUpdate(basket);
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetByID(id);
            if (value is null)
                return NotFound("Sepette böyle bir kayıt yok");

            _basketService.TDelete(value);
            return Ok("Sepetteki ürün silindi");
        }

    }
}
