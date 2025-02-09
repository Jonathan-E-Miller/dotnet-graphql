using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace GraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContosoController(ContosoDbContext context) : ControllerBase
    {
        [HttpGet]
        [Route("products")]
        public IActionResult Products()
        {
            var products = context.DimProducts.Take(10);
            return Ok(products);
        }
    }
}
