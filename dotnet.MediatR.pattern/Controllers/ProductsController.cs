using dotnet.MediatR.pattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.MediatR.pattern.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _mediator.Send(new GetProductsQuery());

            return Ok(products);
        }
    }
}
