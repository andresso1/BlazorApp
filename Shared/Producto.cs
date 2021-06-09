using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared
{
	public class Producto
	{
		private int _ProID;
		private string _ProDesc;
		private decimal _ProValor;

		public Producto(int proID, string proDesc, decimal proValor)
		{
			_ProID = proID;
			_ProDesc = proDesc;
			_ProValor = proValor;
		}

		public Producto()
		{
			_ProID = 0;
			_ProDesc = string.Empty;
			_ProValor = 0.0m;
		}

		public int ProID { get => _ProID; set => _ProID = value; }
		public string ProDesc { get => _ProDesc; set => _ProDesc = value; }
		public decimal ProValor { get => _ProValor; set => _ProValor = value; }
	}
}
