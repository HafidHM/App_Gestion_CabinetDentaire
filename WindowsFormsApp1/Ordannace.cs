using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Ordannace
	{
		private List<String> ligneOrd;


		public Ordannace() {
			LigneOrd = new List<string>();
		}

		public List<string> LigneOrd { get => ligneOrd; set => ligneOrd = value; }
	}
}
