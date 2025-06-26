
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet("{query}")]
    public IActionResult Get(string query)
    {
        var results = new List<object>
        {
            new { Title = $"Amazon Result for {query}", Store = "Amazon", Price = 999, ImageUrl = "https://via.placeholder.com/150" },
            new { Title = $"Flipkart Result for {query}", Store = "Flipkart", Price = 949, ImageUrl = "https://via.placeholder.com/150" }
        };
        return Ok(results);
    }
}
