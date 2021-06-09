using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared
{
	public class Pedido
	{

		private int _PedID;
		private int _PedUsu;
		private int _PedProd;
		private decimal _PedVrUnit;
		private decimal _PedCant;
		private decimal _PedSubTot;
		private decimal _PedIVA;
		private decimal _PedTotal;

		public Pedido(int pedID, int pedUsu, int pedProd, decimal pedVrUnit, decimal pedCant, decimal pedSubTot, decimal pedIVA, decimal pedTotal)
		{
			_PedID = pedID;
			_PedUsu = pedUsu;
			_PedProd = pedProd;
			_PedVrUnit = pedVrUnit;
			_PedCant = pedCant;
			_PedSubTot = pedSubTot;
			_PedIVA = pedIVA;
			_PedTotal = pedTotal;
		}

		public Pedido()
		{
			_PedID = 0;
			_PedUsu = 0;
			_PedProd = 0;
			_PedVrUnit = 0.0m;
			_PedCant = 0.0m;
			_PedSubTot = 0.0m;
			_PedIVA = 0.0m;
			_PedTotal = 0.0m;
		}

		public int PedID { get => _PedID; set => _PedID = value; }
		public int PedUsu { get => _PedUsu; set => _PedUsu = value; }
		public int PedProd { get => _PedProd; set => _PedProd = value; }
		public decimal PedVrUnit { get => _PedVrUnit; set => _PedVrUnit = value; }
		public decimal PedCant { get => _PedCant; set => _PedCant = value; }
		public decimal PedSubTot { get => _PedSubTot; set => _PedSubTot = value; }
		public decimal PedIVA { get => _PedIVA; set => _PedIVA = value; }
		public decimal PedTotal { get => _PedTotal; set => _PedTotal = value; }
	}
}
