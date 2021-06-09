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
	public class UsuarioController : ControllerBase
	{
		
		private readonly ILogger<UsuarioController> logger;

		public UsuarioController(ILogger<UsuarioController> logger)
		{
			this.logger = logger;
		}

		[HttpGet]
		public IEnumerable<Usuario> Get()
		{
			var rng = new Random();
			return Enumerable.Range(1, 5).Select(index => new Usuario
			(
				1,//private int _UsuID;
				"Carlos Eduardo",//private string _UsuNombre;
				"secret"//private string _UsuPass;
			));
		}

	}
}
