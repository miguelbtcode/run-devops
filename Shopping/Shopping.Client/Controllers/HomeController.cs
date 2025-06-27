using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shopping.Client.Data;
using Shopping.Client.Models;

namespace Shopping.Client.Controllers;

public class HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory) : Controller
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("ShoppingAPIClient");
    private readonly ILogger<HomeController> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

    public async Task<IActionResult> Index()
    {
        try
        {
            var response = await _httpClient.GetAsync("/product");

            if (!response.IsSuccessStatusCode)
            {
                ViewBag.ErrorMessage = $"Error: {response.StatusCode}";
                return View(new List<Product>());
            }

            var content = await response.Content.ReadAsStringAsync();
            var productList = JsonConvert.DeserializeObject<IEnumerable<Product>>(content);

            return View(productList ?? new List<Product>());
        }
        catch (Exception e)
        {
            ViewBag.ErrorMessage = "Unable to load products. Please try again later.";
            return View(new List<Product>());
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}