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
	public class PedidoController : ControllerBase
	{
		
		private readonly ILogger<PedidoController> logger;

		public PedidoController(ILogger<PedidoController> logger)
		{
			this.logger = logger;
		}

		[HttpGet]
		public IEnumerable<Pedido> Get()
		{
			var rng = new Random();
			return Enumerable.Range(1, 5).Select(index => new Pedido
			(
				1,//private int _PedID;
				1,//private int _PedUsu;
				1,//private int _PedProd;
				50.0m,//private decimal _PedVrUnit;
				50.0m,//private decimal _PedCant;
				50.0m,//private decimal _PedSubTot;
				50.0m,//private decimal _PedIVA;
				50.0m// private decimal _PedTotal;
			));
		}

	}
}
