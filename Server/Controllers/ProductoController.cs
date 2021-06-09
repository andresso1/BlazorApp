using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlazorApp1.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductoController : ControllerBase
	{
		
		private readonly ILogger<ProductoController> logger;

		public ProductoController(ILogger<ProductoController> logger)
		{
			this.logger = logger;
		}

		[HttpGet]
		public IEnumerable<Producto> Get()
		{
			var rng = new Random();
			return Enumerable.Range(1, 5).Select(index => new Producto
			(
				1,
				"Product 1",
				25.5m
			));
		}

	}
}
