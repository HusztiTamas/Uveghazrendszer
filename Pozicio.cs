using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Pozicio
	{
		int x;
		int y;

		public Pozicio(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public int X { get => x; set => x = value; }
		public int Y { get => y; set => y = value; }

		public override string ToString()
		{
			return $"({x}, {y})";
		}
	}
}
