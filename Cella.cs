using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Cella
	{
		Pozicio poz;
		NovenyFaj noveny;
		int egyedSzam;
		List<Riasztas> riasztasok;
		List<Szenzor> szenzorok;

		public Cella(Pozicio poz)
		{
			NovenyFaj noveny = null;
			this.Poz = poz;
			egyedSzam = 0;
			Riasztasok = new List<Riasztas>();
			Szenzorok = new List<Szenzor>();
		}

		public int EgyedSzam { get => egyedSzam; set => egyedSzam = value; }
		internal Pozicio Poz { get => poz; set => poz = value; }
		internal NovenyFaj Noveny { get => noveny; set => noveny = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }

		public bool UresCella
		{
			get
			{
				return this.noveny == null;
			}
		}

		public bool Beultet(NovenyFaj noveny, int egyedSzam)
		{
			if (this.UresCella)
			{
				this.noveny = noveny;
				this.egyedSzam = egyedSzam;
				if (this.egyedSzam > noveny.OptimaisSuruseg)
				{
					this.noveny.EgeszsegiAllapot -= 2;
				}
				return true;
			}
			else if (noveny == this.noveny)
			{
				this.egyedSzam += egyedSzam;
				if (this.egyedSzam > noveny.OptimaisSuruseg)
				{
					this.noveny.EgeszsegiAllapot -= 2;
				}
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Noveles(int egyedSzam)
		{
			this.Beultet(this.noveny, egyedSzam);
		}

		public void Csokkentes(int egyedSzam)
		{
			this.egyedSzam -= egyedSzam;
			if (this.egyedSzam < 0)
			{
				this.Urit();
			}
		}

		public void Urit()
		{
			this.egyedSzam = 0;
			this.noveny = null;
		}
	}
}
