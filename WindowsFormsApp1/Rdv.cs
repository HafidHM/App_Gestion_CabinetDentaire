using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Rdv
	{
		DateTime dateRdv;
		String etat;
		String nomP;

		public DateTime DateRdv { get => dateRdv; set => dateRdv = value; }
		public string Etat { get => etat; set => etat = value; }
		public string NomP { get => nomP; set => nomP = value; }
	}
}
