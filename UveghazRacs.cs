using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class UveghazRacs
	{
		int meret;
		Cella[,] kert;
		public UveghazRacs(int meret)
		{
			this.meret = meret;
			this.kert = new Cella[this.meret, this.meret];
			Parcellaz();
		}
		private void Parcellaz()
		{
			for (int i = 0; i < this.kert.GetLength(0); i++)
			{
				for (int j = 0; j < this.kert.GetLength(1); j++)
				{
					this.kert[i, j] = new Cella(new Pozicio(i, j));
				}
			}
		}
		public Cella Cellalekedezes(int x, int y)
		{
			return kert[x - 1, y - 1];
		}
		public void Telepit(int x, int y, NovenyFaj noveny, int egyedSzam)
		{
			bool sikeres = kert[x - 1, y - 1].Beultet(noveny, egyedSzam);
			if (sikeres)
			{
				Console.WriteLine($"{noveny.Nev} beültetve a {x},{y} ágyásba");
			}
			else
			{
				Console.WriteLine($"{noveny.Nev} nem lett beültetve a {x},{y} ágyásba");
			}
		}
		public void Kiiratas()
		{
			Console.WriteLine("\n-------------------------------------");
			for (int i = 0; i < this.kert.GetLength(0); i++)
			{
				Console.Write("|");
				for (int j = 0; j < this.kert.GetLength(1); j++)
				{
					if (kert[i, j].UresCella)
					{
						Console.Write($"{"ÜRES",8}|");
					}
					else
					{
						Console.Write($"{kert[i, j].Noveny.Azonosito,3} {kert[i, j].EgyedSzam}db|");
					}
				}
				Console.WriteLine("\n-------------------------------------");
			}
			Console.WriteLine();
		}
		public void Noveles(int x, int y, int mennyiseg)
		{
			kert[x - 1, y - 1].Noveles(mennyiseg);
			Console.WriteLine($"{x},{y} ágyás növénye, a(z) {kert[x - 1, y - 1].Noveny.Nev} az új egyedszám: {kert[x - 1, y - 1].EgyedSzam}");
			if (kert[x - 1, y - 1].Noveny.OptimaisSuruseg > kert[x - 1, y - 1].EgyedSzam)
			{
				Console.WriteLine("A növények jól érzik magukat!");
			}
			else
			{
				Console.WriteLine("A növények túl sokan vannak, nem érzik jól magukat!");
				Csokkentes(x, y, Math.Abs(kert[x - 1, y - 1].Noveny.OptimaisSuruseg - kert[x - 1, y - 1].EgyedSzam));
			}
		}
		public void Csokkentes(int x, int y, int mennyiseg)
		{
			kert[x - 1, y - 1].Csokkentes(mennyiseg);
			Console.WriteLine($"{x},{y} ágyás növénye, a(z) {kert[x - 1, y - 1].Noveny.Nev} az új egyedszám: {kert[x - 1, y - 1].EgyedSzam}");
		}
	}
}
