namespace Uveghazrendszer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kezelo k = new Kezelo("Kovács Péter", "kpeter", Szerepkor.ADMIN);
			Kezelo k1 = new Kezelo("Nagy Anna", "nanna", Szerepkor.KERTESZ);

			NovenyFaj n1 = new NovenyFaj("Paradicsom", 100, 10, 10);
			Cella cella = new Cella(new Pozicio(0, 0));
			Console.WriteLine(cella.UresCella);

			cella.Beultet(n1, 5);
			Console.WriteLine(cella.UresCella);
		}
	}
}
