using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared
{
	public class Usuario
	{

		private int _UsuID;
		private string _UsuNombre;
		private string _UsuPass;


		public Usuario(int usuID, string usuNombre, string usuPass)
		{
			_UsuID = usuID;
			_UsuNombre = usuNombre;
			_UsuPass = usuPass;
		}


		public Usuario()
		{
			_UsuID = 0;
			_UsuNombre = string.Empty;
			_UsuPass = string.Empty;
		}

		public int UsuID { get => _UsuID; set => _UsuID = value; }
		public string UsuNombre { get => _UsuNombre; set => _UsuNombre = value; }
		public string UsuPass { get => _UsuPass; set => _UsuPass = value; }
	}


}
