using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.BasketDtos;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class BasketsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BasketsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index(int id)
        {
            TempData["id"] = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7180/api/Basket/BasketListByMenuTableWithProductName?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBasketDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> DeleteBasket(int id, int tableId)
        {
            if (id <= 0) return BadRequest("Geçersiz basket id");

            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:7180/api/Basket/{id}");

            if (response.IsSuccessStatusCode)
                // ► masa numarasını tekrar Index'e geçir
                return RedirectToAction("Index", new { id = tableId });

            return StatusCode((int)response.StatusCode,
                              "Silme işlemi sırasında API hatası oluştu.");
        }


    }
}
