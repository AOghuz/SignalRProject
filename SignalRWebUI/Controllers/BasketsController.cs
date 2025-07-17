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
        [HttpGet]                                       // /Baskets/DeleteBasket/5
        public async Task<IActionResult> DeleteBasket(int id)
        {
            if (id <= 0)                               // route’dan gelen id yanlışsa
                return BadRequest("Geçersiz id");

            // ► 7180 senin API projesinin gerçek portuysa absolute URL kullan
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync(
                             $"https://localhost:7180/api/Basket/{id}");

            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");      // sepet ekranına dön

            // API 404/500 vb. dönerse
            return StatusCode((int)response.StatusCode,
                              "Silme işlemi sırasında API hatası oluştu.");
        }

    }
}
