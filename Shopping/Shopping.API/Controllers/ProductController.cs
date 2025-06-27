using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController(ILogger<ProductController> logger, ProductContext context)
{
    private readonly ProductContext _context = context ?? throw new ArgumentNullException(nameof(context));
    private readonly ILogger<ProductController> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

    [HttpGet]
    public async Task<IEnumerable<Product>> Get()
    {
        return await _context.Products.Find(p => true).ToListAsync();
    }
}