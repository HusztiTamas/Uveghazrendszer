namespace Uveghazrendszer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kezelo k = new Kezelo("Kovács Péter", "kpeter", Szerepkor.ADMIN);
			Kezelo k1 = new Kezelo("Nagy Anna", "nanna", Szerepkor.KERTESZ);

			NovenyFaj n1 = new NovenyFaj("Paradicsom", 100, 10, 10);
			NovenyFaj n2 = new NovenyFaj("Paprika", 100, 10, 10);
			//Cella cella = new Cella(new Pozicio(0, 0));
			//Console.WriteLine(cella.UresCella);

			//cella.Beultet(n1, 5);
			//Console.WriteLine(cella.UresCella);

			UveghazRacs uveghaz = new UveghazRacs(4);
			uveghaz.Kiiratas();
			uveghaz.Telepit(1, 1, n1, 3);
			uveghaz.Telepit(2, 2, n2, 10);
			uveghaz.Kiiratas();

			uveghaz.Noveles(1, 1, 15);
			uveghaz.Noveles(2, 2, 1);
		}
	}
}
