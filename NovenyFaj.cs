using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class NovenyFaj
	{
		string nev;
		private int vizigeny;//max 100, azon túl egészségi állapota romlik
		int egeszsegiAllapot;//0-10, ahol 0: elpusztult
		int optimaisSuruseg;

		public NovenyFaj(string nev, int vizigeny, int egeszsegiAllapot, int optimaisSuruseg)
		{
			this.Nev = nev;
			this.Vizigeny = vizigeny;
			this.EgeszsegiAllapot = egeszsegiAllapot;
			this.OptimaisSuruseg = optimaisSuruseg;
		}

		public string Azonosito { get => this.nev.Substring(0, 3); }
		public string Nev { get => nev; set => nev = value; }
		public int Vizigeny { get => vizigeny; set => vizigeny = value; }
		public int EgeszsegiAllapot { get => egeszsegiAllapot; set => egeszsegiAllapot = value; }
		public int OptimaisSuruseg { get => optimaisSuruseg; set => optimaisSuruseg = value; }

		public override string ToString()
		{
			return $"{this.nev} ({this.Azonosito}) {this.vizigeny} {this.egeszsegiAllapot}";
		}
	}
}
